using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestAPICore
{
    public class JsonMethod<TRequest, TResponse> where TRequest : RequestBase
    {
        public JsonMethod(JsonClientBase client, Uri relativeUri)
        {
            RelativeUri = relativeUri;
            Client = client;
        }

        public JsonClientBase Client { get; private set; }
        public Uri RelativeUri { get; private set; }



        public async Task<JsonResponse<TResponse>> GetResponseAsync(TRequest request, CancellationToken cancellationToken, IProgress<ProgressReport> progress)
        {

             JsonResponse<TResponse> response ;
            try
            {


                response = await request.GetJsonResponse<TResponse>(
                    Client.BaseUri, 
                    this.RelativeUri, 
                    cancellationToken, 
                    progress, 
                    this.Client.CurrentAuthToken)
                    .ConfigureAwait (false);
                return response;
            }
            catch (AggregateException ex)
            {

                response= new JsonResponse<TResponse>
                (
                    default(TResponse),
                    null,
                    null,
                    null,
                    ex
                );
            }

            await Client.OnRequestComplete(response);
            return response;

        }
    }

    public struct ProgressReport
    {
        public static ProgressReport CreateNew(RequestResponseSteps currentStep, long current, long total)
        {
            var rval = new ProgressReport();
            rval.CurrentStep = currentStep;
            rval.Total = total;
            rval.Current = current;
            return rval;

        }

        public RequestResponseSteps CurrentStep { get; private set; }
        public long Current { get; private set; }
        public long Total { get; private set; }

        public override string ToString()
        {
#if SILVERLIGHT_4||SILVERLIGHT_5||WINDOWS_PHONE_7||WINDOWS_PHONE_8
            return string.Format("{0}/{1} Step:{2} {3}/{4} ", Current, Total, CurrentStep, (int)CurrentStep, 100);
#endif

#if DOTNET45||NETFX_CORE
            return string.Format("{0}/{1} Step:{2} {3}/{4} ", Current, Total, CurrentStep, (int)CurrentStep, Enum.GetValues(typeof(RequestResponseSteps)).Cast<int>().Max());
#endif

        }
    }

    public enum RequestResponseSteps
    {
        PreparingUrl_N_Headers = 0,
        Requesting_N_Uploading = 1,
        GettingResponse = 2,
        Deserializing = 3
    }

}
