using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreProgramsCSharp
{
    internal class LearnAsyncPrograms
    {
        public void LongMethod()
        {
            Console.WriteLine("-------Starting Long method-------");
            Thread.Sleep(5000);//this is going to pause the execution by 5 secs, it takes ms as the input
            Console.WriteLine("---------long method execution finish-------");
        }
        // --async means the method is asynchronous it might be having 1 or more awaits
        public async void CallLongMethod()
        {
            Console.WriteLine("--inside CallLongMethod--");
            //--await keyword ensure that where we have to wait for the intensive computation method and it will release the main thread
            //--Task.Run  is used to create a new thread to run this method, but if this method is async as well then we need not to use Task.Run
            //--Action is a delegate of type void
            await Task.Run(new Action(LongMethod));
            Console.WriteLine("--CallLongMethod finshed exec---");
        }
    }
}
