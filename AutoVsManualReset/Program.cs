using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoVsManualReset
{
    class Program
    {

        static void Main(string[] args)
        {

            _ManualResetEvent reset_event = new _ManualResetEvent();
            reset_event.Init();

        }
    }
}
