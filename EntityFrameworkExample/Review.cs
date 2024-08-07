using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Review
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Comment {  get; set; }
        public string Score {  get; set; }
        public int ProductId {  get; set; }
        public Product Product {  get; set; } 
    }
}
