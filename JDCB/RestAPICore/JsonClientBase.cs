using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPICore
{
    public abstract class JsonClientBase
    {
        public Uri BaseUri { get; set; }
        public AuthToken CurrentAuthToken { get; set; }
        public event RequestCompletedEventHandler RequestComplete;
        internal async Task OnRequestComplete(JsonResponse response)
        {
            await RequestComplete(this, new RequestCompletedEventArgs(response)).ConfigureAwait(false);
        }

    }
}
