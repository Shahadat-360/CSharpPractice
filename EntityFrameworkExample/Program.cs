using EntityFrameworkExample;

ShopDbContext shopDbContext = new ShopDbContext();

Product product = new Product
{
    Name="Camera",
    Description="Cannon",
    Price=80000,
    Reviews= new List<Review>
    {
        new Review{Email="1337.Shahadat@gmail.com",Comment="Very Nice Product",Score="4.7"},
        new Review{Email="Shahadat.ice.pust@gmail.com",Comment="Love to use the Camera",Score="5"}
    },
    PurchaseOrders= new List<PurchaseOrder>
    {
        new PurchaseOrder{Customer=new Customer{Name="Shahadat",Address="Comilla"}},
        new PurchaseOrder{Customer=new Customer{Name="Fazlay",Address="Microsoft"}}
    }  
};

shopDbContext.Products.Add(product);
shopDbContext.SaveChanges();