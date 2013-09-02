using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RestAPICore
{
    public class JsonContractException : Exception
    {

        public JsonContractException(string message, Exception innerException, Stream responseStreamCopy, IDictionary<string, string[]> headers)
            : base(message, innerException)
        {
            Headers = headers;
            ResponseStreamCopy = responseStreamCopy;
        }

        public Stream ResponseStreamCopy { get; set; }
        public IDictionary<string, string[]> Headers { get; set; }
    }
}
