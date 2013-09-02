using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace RestAPICore
{
    //public interface MethodLogListener
    //{
    //    Task Log(MethodCompletedEventArgs context);


    //}


    //public class DelegateMethodLogListener : MethodLogListener
    //{
    //    public DelegateMethodLogListener(Func<MethodCompletedEventArgs, Task> logAction)
    //    {
    //        _logAction = logAction;
    //    }

    //    Func<MethodCompletedEventArgs,Task> _logAction;

    //    public async Task Log(MethodCompletedEventArgs context)
    //    {
    //         await _logAction(context);
    //    }

 
    //}

    public delegate Task RequestCompletedEventHandler (object sender,RequestCompletedEventArgs eventArgs);


    public class RequestCompletedEventArgs : EventArgs
    {

        public RequestCompletedEventArgs(JsonResponse response)
        {
            Response = response;
        }
       public  JsonResponse Response { get; private set; }

    }

}
