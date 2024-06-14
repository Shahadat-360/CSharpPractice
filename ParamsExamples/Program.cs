void sum(params int[] arr)
{
    int s = 0;
    foreach (var x in arr) s += x;
    Console.WriteLine(s);
}

sum(2, 7, 8);
sum(3, 9, 10, 11, 12);
void change(ref int k)
{
    k = 6;
}

void InKeyword(in int k)
{
    //k = 5; can't be used only k can be used not able to modified the k
    Console.WriteLine(k);
}

void OutKeyword(out int k)
{
    k = 7;
}  

int y = 5;
change(ref y);
Console.WriteLine(y);
InKeyword(y);
OutKeyword(out y);
Console.WriteLine(y);