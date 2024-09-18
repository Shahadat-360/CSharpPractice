void PrintOddNumbers()
{
    for (int i = 1;i<=100;i+=2)
        Console.WriteLine(i);
}

void PrintEvenNumbers()
{
    for (int i = 0; i <= 100; i+=2)
        Console.WriteLine(i);
}

Thread t1 = new Thread(()=>PrintOddNumbers());
Thread t2 = new Thread(()=>PrintEvenNumbers());

t1.Start();
t2.Start();