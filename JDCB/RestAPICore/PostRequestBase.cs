using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPICore
{
    public abstract class PostRequestBase : RequestBase
    {
        public PostRequestBase()
        {
            //PostFieldValues = new SortedDictionary<string, List<string>>();
            base._requestMethod = "POST";
        }

      
    }
}
