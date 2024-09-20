using NewSwitchCase;

var x = 0;
//var option = 2;
//x = option switch
//{
//    0 => x + 5,
//    1 => 1,
//    2 => 2,
//    _ => 12
//};

var person = new Person { Name = "Shahadat", Age = 25 };

x = person switch
{
    { Name:"jalal"} => x+1,
    { Age:26}=>25,
    { Name:_,Age:_}=> 0
};

Console.WriteLine(x);