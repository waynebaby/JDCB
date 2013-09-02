using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestAPICore
{
    public class PostRequest : PostRequestBase
    {
        protected override async Task FillDataTo(System.Net.WebRequest webrqst, CancellationToken cancellationToken, IProgress<ProgressReport> progress)
        {


            progress.ReportWhenNotNull(() => ProgressReport
                .CreateNew(RequestResponseSteps
                .Requesting_N_Uploading, 0, 1));
            var qd = System.Text.Encoding.UTF8.GetBytes(JsonClientHelper.GetQueryData(RequestData.PostFieldValues));

            webrqst.ContentType = "application/x-www-form-urlencoded";
#if SILVERLIGHT_4||SILVERLIGHT_5||DOTNET45

            webrqst.ContentLength = qd.Length;
    
#endif




            var rqstStrm = await webrqst.GetRequestStreamAsync().ConfigureAwait(false);
            await rqstStrm.WriteAsync(qd, 0, qd.Length).ConfigureAwait(false);
            progress.ReportWhenNotNull(() => ProgressReport
                .CreateNew(RequestResponseSteps
                .Requesting_N_Uploading, 1, 1));
        }
    }
}
