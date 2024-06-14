using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExamples
{
    internal class Vehicle
    {
        protected virtual double startEngine(double initialSpeed)
        {
            return initialSpeed * 1.5;
        }
    }
}
