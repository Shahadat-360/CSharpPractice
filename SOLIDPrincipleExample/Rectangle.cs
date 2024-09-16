using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class Rectangle : Shape
    {
        public double Height {  get; set; }
        public double Width {  get; set; }

        public double CalculateArea()
        {
            return Height * Width;
        }

    }
}
