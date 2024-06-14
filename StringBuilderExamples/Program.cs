using System.Text;

StringBuilder sb = new StringBuilder();
string st = "ha";
sb.Append(st);
sb.Append("bibi");
sb.Append([' ','S','h','a','h','a','d','a','t']);
Console.WriteLine(sb.ToString());


string initialString = "Initial string for stringbuilder.";
int startIndex = 2;
int substringLength = 14;
int capacity = 255;
StringBuilder stringBuilder = new StringBuilder(initialString,
    startIndex, substringLength, capacity);
Console.WriteLine(stringBuilder.ToString());


foreach (ReadOnlyMemory<char> chunk in sb.GetChunks())
{
    var span = chunk.Span;
    Console.WriteLine(span.ToString());
    for (int i = 0; i < span.Length; i++)
    {
        Console.WriteLine(span[i]);                  
    }
}