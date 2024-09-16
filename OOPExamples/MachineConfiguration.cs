using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class MachineConfiguration : IMachine
    {
        public void start()
        {
            Console.WriteLine("I am starting");
        }
    }
}
