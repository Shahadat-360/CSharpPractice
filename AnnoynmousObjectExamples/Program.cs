//object o = new { }; // syntax for annonymous object
var o = new { Name = "MD. Shahadat", Roll = 190621 };
Console.WriteLine(o.Name);
Console.WriteLine(o.Roll);

dynamic Get2Number()
{
    return new { n1 = 1.5, n2 = 2.5 };
}

var res = Get2Number();
Console.WriteLine(res.n1);
Console.WriteLine(res.n2);