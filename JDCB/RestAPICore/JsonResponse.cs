using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace RestAPICore
{
    public class JsonResponse<T> : JsonResponse
    {

        public JsonResponse(T value, WebRequest request, WebResponse response, Stream inputCopy,Exception exception=null)
        {
            Value = value;
            ResponseStreamCopy = inputCopy;
            Request = request;
            Response = response;
            Exception = exception;
        }
        public T Value { get; private set; }




        public override object ValueObject
        {
            get { return Value; }
        }
    }

    public abstract  class JsonResponse
    {

        public abstract  Object ValueObject { get;  }
        public Stream ResponseStreamCopy { get; protected  set; }
        public WebResponse Response { get; protected set; }
        public Exception Exception { get; protected set; }
        public WebRequest Request { get; protected set; }
    
    }
    
}
