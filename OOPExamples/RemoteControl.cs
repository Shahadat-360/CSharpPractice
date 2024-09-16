using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class RemoteControl
    {
        private readonly IMachine _machine;
        public RemoteControl(IMachine machine)
        {
            _machine = machine;
        }
        public void OnPress()
        {
            _machine.start();
        }
    }
}
