using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace RestAPICore
{
    public class MultiPartPostRequest : PostRequestBase
    {
        static readonly byte[] CRLFBYTES = Encoding.UTF8.GetBytes("\r\n");
        public MultiPartPostRequest()
        {

        }

        protected override async Task FillDataTo(System.Net.WebRequest webRequest, CancellationToken cancellationToken, IProgress<ProgressReport> progress)
        {


            var memStream = new MemoryStream();

            // 边界符  
            var boundary = "---------------" + DateTime.Now.Ticks.ToString("x");
            // 边界符  
            var beginBoundary = Encoding.UTF8.GetBytes("--" + boundary + "\r\n");
            //var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);  
            // 最后的结束符  
            var endBoundary = Encoding.UTF8.GetBytes("--" + boundary + "--\r\n");

            // 设置属性  

            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;

            // 写入文件  
            const string filePartHeader =
                "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
                 "Content-Type: application/octet-stream\r\n\r\n";


            foreach (var fileKvp in RequestData.UploadFiles)
            {
                var value = fileKvp.Value;
                memStream.Write(beginBoundary, 0, beginBoundary.Length);
                var header = string.Format(filePartHeader, fileKvp.Key, value.LocalPath);
                var headerbytes = Encoding.UTF8.GetBytes(header);
                memStream.Write(headerbytes, 0, headerbytes.Length);

                var stream = await value.StreamFactory.ConfigureAwait(false);

                await stream.CopyToAsync(memStream).ConfigureAwait(false);

                // await memStream.WriteAsync(beginBoundary, 0, beginBoundary.Length); 

                memStream.Write(CRLFBYTES, 0, CRLFBYTES.Length);
            }

            if (cancellationToken.IsCancellationRequested) cancellationToken.ThrowIfCancellationRequested();
            // 写入字符串的Key  


            var stringKeyHeader = "Content-Disposition: form-data; name=\"{0}\"" +
                                   "\r\n\r\n{1}\r\n";

            foreach (byte[] formitembytes in (
                this.RequestData.PostFieldValues

                .SelectMany(kvp => kvp.Value.Select(x => new { kvp.Key, Value = x }))
                )
                .Select(
                keyvp =>
                {
                    return string.Format(stringKeyHeader, keyvp.Key, keyvp.Value);
                }
                )
                .Select
                (
                    str => Encoding.UTF8.GetBytes(str)

                ))
            {
                memStream.Write(beginBoundary, 0, beginBoundary.Length);
                memStream.Write(formitembytes, 0, formitembytes.Length);
            }

            // 写入最后的结束边界符  
            memStream.Write(endBoundary, 0, endBoundary.Length);
#if SILVERLIGHT_4||SILVERLIGHT_5||DOTNET45

            webRequest.ContentLength = memStream.Length;
#endif



            if (cancellationToken.IsCancellationRequested) cancellationToken.ThrowIfCancellationRequested();


            var requestStream = await webRequest.GetRequestStreamAsync().ConfigureAwait(false);

            memStream.Position = 0;
            //await memStream.CopyToAsync(requestStream, 512 * 1024, cancellationToken);
            var total = memStream.Length;
            var current = 0;
            var buffer = new byte[4096];
            var sourceStream = memStream;
            var eof = false;
            while (!eof)
            {
                progress.ReportWhenNotNull(() => ProgressReport.CreateNew(RequestResponseSteps.Requesting_N_Uploading, current, total));
                cancellationToken.ThrowIfCancellationRequested();
                var readCount = await sourceStream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                current = current + readCount;

                eof = (readCount == 0);
                if (!eof) requestStream.Write(buffer, 0, readCount);
            }

            //requestStream.Close();
        }
    }

    public class FileUploadInfo
    {
        /// <summary>
        /// 文件在客户端的路径
        /// </summary>
        public string LocalPath { get; set; }

        /// <summary>
        /// 如何打开文件的异步方法
        /// </summary>
        public Task<Stream> StreamFactory { get; set; }
    }

}