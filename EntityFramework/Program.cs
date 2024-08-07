using EntityFramework;
using Microsoft.EntityFrameworkCore;

ShopDbContext shopDbContext = new ShopDbContext();

//Product product = new Product
//{
//    Name = "Laptop",
//    Description = "HP",
//    Price = 800000,
//    Reviews = new List<Review>
//    {
//        new Review { Email = "1337.Shahadat@gmail.Com", Comment = "Very Nice Laptop", Score = "4.9" },
//        new Review { Email = "Shahadat.ice.pust@gmail.Com", Comment = "I Love the laptop", Score = "4.5" }
//    },
//    PurchaseOrders = new List<PurchaseOrder>
//    {
//        new PurchaseOrder{ Customer = new Customer { Name="Shahadat",Address="Gulshan"} },
//        new PurchaseOrder{Customer= new Customer { Name="Microsoft",Address="USA"}}
//    }
//};
//shopDbContext.Products.Add(product);

//Product product2 = shopDbContext.Products.Where(x=>x.Name=="Camera").First();
//Console.WriteLine(product2.Price);

//product2.Price = 20000;
shopDbContext.SaveChanges();

//shopDbContext.Products.Remove(product2);
//shopDbContext.SaveChanges();


Customer customer=shopDbContext.Customers.Where(x=>x.Name=="Adhi").First();
Product product2=shopDbContext.Products.Where(x=>x.Name=="Camera")
    .Include(x=>x.Reviews)
    .Include(x=>x.PurchaseOrders)
    .First();

Console.WriteLine(product2.Name);
product2.PurchaseOrders = new List<PurchaseOrder>();
product2.PurchaseOrders.Add(new PurchaseOrder { Customer = customer });
shopDbContext.SaveChanges();
