using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization;

namespace RestAPICore
{
    [DataContract]
    public abstract class AuthToken
    {
        public AuthToken()
        {
            ContextData = new Dictionary<string, object>();            

        }
        internal protected abstract void FillToContext(string baseUrl, RequestBase context);
        internal protected abstract void FillToWebRequest(WebRequest request, RequestBase context);
        [DataMember]
        public Dictionary<string,object>  ContextData { get; private set; }
    }
}
