using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPICore
{
    public class RequestData
    {

        public RequestData()
        {
            this.HeaderValues = new Dictionary<string, List<string>>();
            this.PostFieldValues = new Dictionary<string, List<string>>();
            this.QueryStringValues = new Dictionary<string, List<string>>();
            this.UploadFiles = new Dictionary<string, FileUploadInfo>();

            this.UrlTemplateValues = new Dictionary<string, string>();


        }

        public Dictionary<string, List<string>> HeaderValues
        {
            get;
            set;
        }

        public Dictionary<string, List<string>> PostFieldValues { get; set; }

        public Dictionary<string, List<string>> QueryStringValues
        {
            get;
            set;
        }

        public Dictionary<string, FileUploadInfo> UploadFiles { get; set; }

        public Dictionary<string, string> UrlTemplateValues
        {
            get;
            set;
        }
    }
}
