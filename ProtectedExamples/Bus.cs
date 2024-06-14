using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExamples
{
    internal class Bus:Vehicle
    {
        protected override double startEngine(double initialSpeed)
        {
            return initialSpeed * 2.5;
        }
    }
}
