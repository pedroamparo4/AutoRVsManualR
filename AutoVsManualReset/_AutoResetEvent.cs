using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoVsManualReset
{
    public class _AutoResetEvent
    {

        EventWaitHandle _wait_handle = new AutoResetEvent(false);

        public _AutoResetEvent()
        {
           
        }

        public void Init()
        {
            new Thread(WaitingMethod).Start();
            new Thread(WaitingMethod).Start();
            new Thread(WaitingMethod).Start();
            Thread.Sleep(1500);


            _wait_handle.Set();
            Thread.Sleep(1500);
            _wait_handle.Set();
            Thread.Sleep(1500);
            _wait_handle.Set();
        }

        private void WaitingMethod()
        {
            Console.WriteLine("Waiting....");
            _wait_handle.WaitOne();
            Console.WriteLine("...Completed!");
        }
    }
}
