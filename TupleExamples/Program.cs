(int v1,int v2) Get2Numbers()
{
    int x=1; int y=2;
    return (x+y,x-y);
}

var x = Get2Numbers();
Console.WriteLine($"{x.v1} {x.v2}");

(int,double) GetIntAndDoubleNumber()
{
    return (100, 2.5);
}
var y = GetIntAndDoubleNumber();
Console.WriteLine($"{y.Item1} {y.Item2}");
