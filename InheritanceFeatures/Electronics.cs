using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeatures
{
    internal class Electronics:Product
    {
        public override decimal discountedPrice(decimal discountedPrice)
        {
            return Price - discountedPrice;
        }
    }
}
