using System.Linq.Expressions;

Expression<Func<int, int, double>> e = (int a, int b) => a / b;
var  f = e.Compile();
Console.WriteLine(f(5, 6));