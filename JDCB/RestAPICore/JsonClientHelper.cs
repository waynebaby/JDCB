using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
namespace RestAPICore
{
    public static class JsonClientHelper
    {

        public static Task<TResponse> ExecuteAsync<TRequest, TResponse>(string url, TRequest request) where TRequest : RequestBase
        {
            var webr = WebRequest.Create(url);
            throw new NotImplementedException();
        }

        private static string AppendTemplate(string urlTemplate, IDictionary<string, string> urlTemplateValues)
        {
            var sb = new StringBuilder(urlTemplate);
            foreach (var kv in urlTemplateValues)
                sb.Replace("{" + kv.Key + "}", kv.Value);

            var txt = sb.ToString();
            return
                (txt.StartsWith("/") ? "" : "/")
                + txt;
        }

        public static UriBuilder GetBaseUriBuilder(Uri baseUri, Uri relativeUri, IDictionary<string, string> urlTemplateValues = null)
        {
            if (urlTemplateValues == null)
                urlTemplateValues = new Dictionary<string, string>();

            var b = new UriBuilder(baseUri);
            b.Path = (b.Path == "/" ? "" : b.Path) + AppendTemplate(relativeUri.ToString(), urlTemplateValues);
            return b;
        }

        public static string GetAbsoultUrl(Uri baseUri, Uri relativeUri, IEnumerable<KeyValuePair<string, List<string>>> queryStringValues, IDictionary<string, string> urlTemplateValues = null)
        {
            var b = GetBaseUriBuilder(baseUri, relativeUri, urlTemplateValues);
            var qstr = GetQueryData(
                                       queryStringValues
                                           .Select(
                                               kv => new KeyValuePair<string, List<string>>(
                                               kv.Key, kv.Value.Select(s => kv.Key.StartsWith("oauth_") ? s : UrlEncode(s)).ToList())),
                                       false);

            return b.Uri.AbsoluteUri + (string.IsNullOrEmpty(qstr) ? string.Empty : "?" + qstr);
        }
        public static TDic MergeDictionary<TKey, TValue, TDic>(TDic d1, TDic d2) where TDic : IDictionary<TKey, TValue>, new()
        {
            var mergedUrlTemplateValues = new TDic();

            var mkvp = d1.Union(d2);
            mkvp.ToList()
            .ForEach(kvp =>
            {
                if (mergedUrlTemplateValues.ContainsKey(kvp.Key))
                {
                    mergedUrlTemplateValues[kvp.Key] = kvp.Value;
                }
                else
                {
                    mergedUrlTemplateValues.Add(kvp.Key, kvp.Value);
                }
            })
            ;

            return mergedUrlTemplateValues;
        }
        public static string GetQueryData(IEnumerable<KeyValuePair<string, List<string>>> data, bool needEncode = true)
        {
            var ql = data
                .SelectMany(x => x.Value.Select(v => new { Key = x.Key, Value = v }))
                .SelectMany(x => new string[] { x.Key, "=", needEncode ? Encode(x.Value) : x.Value, "&" })
                .ToList();
            if (ql.Count > 0) ql.RemoveAt(ql.Count - 1);
            var qstr = string.Concat(ql.ToArray());
            return qstr;
        }

        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder newStr = new StringBuilder();

            foreach (var item in input)
            {
                if (IsReverseChar(item))
                {
                    newStr.Append("%");
                    var temp = ((int)item).ToString("X2");
                    newStr.Append(temp);
                }
                else
                    newStr.Append(item);
            }

            return newStr.ToString();
        }

        public static string UrlEncode(string input)
        {
            StringBuilder newBytes = new StringBuilder();
            var urf8Bytes = Encoding.UTF8.GetBytes(input);
            foreach (var item in urf8Bytes)
            {
                if (IsReverseChar((char)item))
                {
                    newBytes.Append('%');
                    newBytes.Append(item.ToString("X2"));
                }
                else
                    newBytes.Append((char)item);
            }
            return newBytes.ToString();
        }

        private static bool IsReverseChar(char c)
        {
            return !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')
                    || c == '-' || c == '_' || c == '.' || c == '~');
        }

        internal static void ReportWhenNotNull<T>(this IProgress<T> progress, Func<T> valueFactory)
        {
            if (progress != null)
            {
                progress.ReportWhenNotNull(() => valueFactory());
            }

        }




    }
}
