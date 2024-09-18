try
{
    Console.Write("Please Enter a Number: ");
    int n = int.Parse(Console.ReadLine());  
}
catch(Exception ex)
{
    Console.WriteLine("Please Enter Number Not String");
    Console.WriteLine(ex.ToString());
}
finally
{
    Console.WriteLine("Good Luck");
}