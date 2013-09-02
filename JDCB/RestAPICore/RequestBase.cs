using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace RestAPICore
{
    public abstract class RequestBase
    {
        public RequestBase()
        {
            RequestData = new RequestData();
        }

        public string RequestMethod
        {
            get 
            { 
                return _requestMethod; 
            }
        }

        public RequestData RequestData
        {
            get;
            set;
        }

        protected string _requestMethod;

        internal async Task<JsonResponse<TResponse>> GetJsonResponse<TResponse>(Uri baseUri, Uri relativeUri, CancellationToken cancellationToken, IProgress<ProgressReport> progress,AuthToken token=null )
        {
            progress.ReportWhenNotNull( ()=>ProgressReport.CreateNew(RequestResponseSteps.PreparingUrl_N_Headers, 0, 1));
            //验证对于一般的请求参数修改 
            if (token != null)
            {
                var baseUrl = JsonClientHelper.GetBaseUriBuilder(baseUri, relativeUri, this.RequestData.UrlTemplateValues).Uri.ToString();
                token.FillToContext(baseUrl, this);
            }

            var uri = new Uri(JsonClientHelper.GetAbsoultUrl(baseUri, relativeUri, this.RequestData.QueryStringValues, this.RequestData.UrlTemplateValues));

#if DOTNET45
            var webrqst = WebRequest.CreateDefault(uri);
#else
            var webrqst = WebRequest.Create(uri);
#endif 

            webrqst.Method = RequestMethod;
            //验证对于底层请求参数修改 
            if (token != null)
            {
                token.FillToWebRequest(webrqst,this);
            }

            FillToHeader(webrqst);
            progress.ReportWhenNotNull( ()=>ProgressReport.CreateNew(RequestResponseSteps.PreparingUrl_N_Headers, 1, 1));

            await FillDataTo(webrqst, cancellationToken, progress).ConfigureAwait(false);

            if (typeof(WebRequest) == (typeof(TResponse)))
            {
                var o = new JsonResponse<WebRequest>(webrqst, webrqst, null, null);
                progress.ReportWhenNotNull(() => ProgressReport.CreateNew(RequestResponseSteps.Deserializing, 1, 1));
                return o as JsonResponse<TResponse>;
            }

            using (var webrsps = await webrqst.GetResponseAsync().ConfigureAwait(false))
            {

            
                if (typeof(WebResponse) == (typeof(TResponse)))
                {
                    var o = new JsonResponse<WebResponse>(webrsps,webrqst,webrsps, null);
                    progress.ReportWhenNotNull( ()=>ProgressReport.CreateNew(RequestResponseSteps.Deserializing, 1, 1));
                    return o as JsonResponse<TResponse>;
                }
#if SILVERLIGHT_4||SILVERLIGHT_5||WINDOWS_PHONE_7
                var h = new Dictionary<string, string[]>();
#endif

#if DOTNET45 || WINDOWS_PHONE_8
                var h = webrsps.Headers.AllKeys
                .Select(k => new { k, v = webrsps.Headers[k].Split(',') })
                .ToDictionary(x => x.k, x => x.v);
#endif

#if NETFX_CORE
                 var h = webrsps.Headers.AllKeys
                .Select(k => new { k, v = webrsps.Headers[k].Split(',') })
                .ToDictionary(x => x.k, x => x.v);
#endif
                var ms = new MemoryStream();
                var total = webrsps.ContentLength;
                var current = 0;
                var buffer = new byte[4096];
                var sourceStream = webrsps.GetResponseStream();
                var eof = false;
                while (!eof)
                {
                    progress.ReportWhenNotNull( new Func<ProgressReport> (()=>ProgressReport.CreateNew(RequestResponseSteps.GettingResponse, current, total)));
                    cancellationToken.ThrowIfCancellationRequested();
                    var readCount = await sourceStream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                    current = current + readCount;

                    eof = (readCount == 0);
                    if (!eof) ms.Write(buffer, 0, readCount);
                }
         
                if (typeof(Stream) == (typeof(TResponse)))
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    var value = ms;
                    var o = new JsonResponse<Stream>(value, webrqst,webrsps, ms);
                    progress.ReportWhenNotNull( ()=>ProgressReport.CreateNew(RequestResponseSteps.Deserializing, 1, 1));
                    return o as JsonResponse<TResponse>;
                }
                else
                {
                    try
                    {
                        progress.ReportWhenNotNull( ()=>ProgressReport.CreateNew(RequestResponseSteps.Deserializing, 0, 1));
                        ms.Seek(0, SeekOrigin.Begin);
                        var value = (TResponse)JsonSerializerCache<TResponse>.Serializer.ReadObject(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        var o = new JsonResponse<TResponse>(value, webrqst, webrsps, ms);
                        progress.ReportWhenNotNull( ()=>ProgressReport.CreateNew(RequestResponseSteps.Deserializing, 1, 1));
                        return o;
                    }
                    catch (Exception ex)
                    {
                        ms.Seek(0, SeekOrigin.Begin);
                        return new JsonResponse<TResponse>(
                            default(TResponse) ,                            
                            webrqst,
                            webrsps,
                            ms,
                            new JsonContractException("Serializing exception", ex, ms, h)
                        );
                    }
                }

            }

        }

        private void FillToHeader(WebRequest webrqst)
        {
#if SILVERLIGHT_4||SILVERLIGHT_5||WINDOWS_PHONE_7||WINDOWS_PHONE_8
            this.RequestData.HeaderValues
                .SelectMany(kvp => kvp.Value.Select(v => new { Key = kvp.Key, Value = v }))
                .ToList().ForEach(hv => { webrqst.Headers[hv.Key] = hv.Value; });
#endif
#if NETFX_CORE
            this.RequestData.HeaderValues
                .SelectMany(kvp => kvp.Value.Select(v => new { Key = kvp.Key, Value = v }))
                .ToList().ForEach(hv => { webrqst.Headers[hv.Key] = hv.Value; });
#endif
#if DOTNET45
            this.RequestData.HeaderValues
                .SelectMany(kvp => kvp.Value.Select(v => new { Key = kvp.Key, Value = v }))
                .ToList().ForEach(hv => { webrqst.Headers.Add(hv.Key + ":" + hv.Value); });
#endif
        }

        protected abstract Task FillDataTo(WebRequest webRequest, CancellationToken cancellationToken, IProgress<ProgressReport> progress);

    }

    static class JsonSerializerCache<T>
    {
        static public readonly DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(T));
    }
}
