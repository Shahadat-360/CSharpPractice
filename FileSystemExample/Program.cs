//using System.Text;

//string text = Console.ReadLine();
//byte[] bytes = Encoding.UTF8.GetBytes(text);
//using FileStream file = File.Create("hello.txt");
//file.Write(bytes);

//FileInfo file1 = new FileInfo("Hello2.txt");
//using FileStream stream = file1.Create();
//stream.Write(bytes);

using System.Text;

byte[] bytes = new byte[2];
using FileStream fileStream = File.Open("hello.txt", FileMode.Open);
long byteSize = fileStream.Length;
for (int i = 0; i < byteSize; i += 2)
{
    fileStream.Read(bytes, 0, 2);
    Console.WriteLine(Encoding.UTF8.GetString(bytes));
}