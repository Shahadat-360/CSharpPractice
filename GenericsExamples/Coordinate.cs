using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    internal class Coordinate<T>
    where T : IEquatable<T>
    {
        public T x { get; set; }
        public T y { get; set; }

        public Coordinate(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public void ThreeDimension<R, S>(R item,S item2)
        {
            Console.WriteLine($"{item} {item2}");
        }
        public bool isSame(T x,T y) { 
            return x.Equals(y);
        }
    }
}
