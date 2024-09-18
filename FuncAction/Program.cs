//print(1,2,(int a,int b)=>a*b);

//Func 
//void print(int a,int b,Func<int,int,int> calculate)
//{
//    Console.WriteLine(calculate(a,b));
//}

//Action
//var x =(int a,int b) => { Console.WriteLine(a*b); };
print(2, 3, (int a, int b) => { Console.WriteLine(a * b); });
void print(int a,int b,Action<int,int> action)
{
    action(a,b);
}