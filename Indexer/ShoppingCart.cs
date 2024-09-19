using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();
        public Product this[int Position]
        {
            get
            {
                return products[Position];
            }
            set
            {
                products.Add(value);
                if(Position<products.Count)
                    products[Position] = value;
            }
        }
    }
}
