using AdonetExample;

//var FirstName=Console.ReadLine();
//var LastName=Console.ReadLine();
//var DateOfBirth=DateTime.Parse(Console.ReadLine());
//var IsMarried=bool.Parse(Console.ReadLine());

var connectionString = "Server=SHAHADAT-PC\\SQLEXPRESS;Database=CSharpB17;User Id=CSharpB17;Password=123456;Trust Server Certificate=True";

var InsertCommandText = $"insert into Customers(FirstName,LastName,DateOfBirth,IsMarried) values(@FirstName,@LastName,@DateOfBirth,@IsMarried)";
var DeleteCommandText = "delete from Customers where id=1006";
var SelectQuery = "select * from Customers";

//Dictionary<string,object> Parameters = new Dictionary<string,object>();
//Parameters.Add("FirstName",FirstName);
//Parameters.Add("LastName", LastName);
//Parameters.Add("DateOfBirth", DateOfBirth);
//Parameters.Add("IsMarried",IsMarried);

using AdonetUtility adonetUtility = new AdonetUtility(connectionString);
adonetUtility.ExecuteCommand(DeleteCommandText);

var result = adonetUtility.ExecuteQuery(SelectQuery);

foreach (var item in result)
{
    foreach (var row in item)
    {
        Console.Write($"{row.Key}: {row.Value}  ");
    }
    Console.WriteLine();
}