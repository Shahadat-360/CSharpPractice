using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeatures
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual decimal discountedPrice(decimal discountedPrice)
        {
            return Price - discountedPrice;
        }
    }
}
