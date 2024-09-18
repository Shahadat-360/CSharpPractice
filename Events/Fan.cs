using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Fan
    {
        public void Rotating(bool State)
        {
            if (State)
            {
                Console.WriteLine("Fan is Rotating");
            }
            else
            {
                Console.WriteLine("Fan is Off");
            }
        }
    }
}
