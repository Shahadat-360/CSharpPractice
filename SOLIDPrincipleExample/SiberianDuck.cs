using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class SiberianDuck : IFlyable, ISwimable, IQuak
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Quak()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
