using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace RestAPICore
{
    static public class ExtensionPatchs
    {
#if WINDOWS_PHONE_8

        public static Task<System.Net.WebResponse> GetResponseAsync(this System.Net.WebRequest request)
        {
            return Task.Factory.FromAsync(request.BeginGetResponse(null, null), ia => request.EndGetResponse(ia));
        }


        public static Task<System.IO.Stream> GetRequestStreamAsync(this System.Net.WebRequest request)
        {
            return Task.Factory.FromAsync(request.BeginGetRequestStream(null, null), ia => request.EndGetRequestStream(ia));
        }
        #endif
#if SILVERLIGHT_4||WINDOWS_PHONE_7||SILVERLIGHT_5

        public static async Task TaskYield()
        {
             await TaskEx.Yield();
        
        }

#else

        public static async Task TaskYield()
        {
            await Task.Yield();

        }
      
#endif

    }
}
