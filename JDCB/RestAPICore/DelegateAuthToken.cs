using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization;

namespace RestAPICore
{
    [DataContract]
    public class DelegateAuthToken : AuthToken
    {

        public DelegateAuthToken(Action<IDictionary<string, object>, WebRequest, RequestBase> requestAction = null, Action<IDictionary<string, object>, string, RequestBase> contextAction = null)
        {
            _requestAction = requestAction;
            _contextAction = contextAction;
        }
        Action<IDictionary<string, object>, WebRequest, RequestBase> _requestAction;
        Action<IDictionary<string, object>, string, RequestBase> _contextAction;

        protected internal override void FillToContext(string baseUrl, RequestBase context)
        {
            if (_contextAction != null)
            {
                _contextAction(this.ContextData, baseUrl, context);
            }
        }

        protected internal override void FillToWebRequest(WebRequest request, RequestBase context)
        {
            if (_requestAction != null)
            {
                _requestAction(this.ContextData, request, context);
            }
        }
    }
}
