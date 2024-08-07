using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }

        public List<Review> Reviews { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set;}
    }
}
