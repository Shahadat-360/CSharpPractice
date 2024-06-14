using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFeatures
{
    internal class Bus : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Hello Bus Engine");
        }
    }
}
