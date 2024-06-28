#region List Examples
List<int> list = new List<int>();
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(10);
foreach (var x in list) Console.Write(x.ToString() + " ");
Console.WriteLine();
#endregion

#region Dictionary
Dictionary<string,int> Result= new Dictionary<string,int>();
Result.Add("Shahadat", 100);
Result.Add("Masud", 150);
Result.Add("Shourov", 200);
Result.Add("Mitu", 250);
foreach(var x in Result)Console.WriteLine(x.Key + ": " + x.Value);  
#endregion

