using static Delegate.MathExample;

//Calculate addition = sum;
//int sum(int a,int b)=>a + b;
//int multiply(int a,int b) => a * b;


void print(int a,int b,Calculate calculate)
{
    Console.WriteLine(calculate(a,b));
}

print(1,2,(int a,int b)=>a*b);

//Console.WriteLine(addition(5, 6)); 
//Console.WriteLine(multiply(5, 6));