////using System.Text;

////string text = Console.ReadLine();
////byte[] bytes = Encoding.UTF8.GetBytes(text);
////using FileStream file = File.Create("hello.txt");
////file.Write(bytes);

////FileInfo file1 = new FileInfo("Hello2.txt");
////using FileStream stream = file1.Create();
////stream.Write(bytes);

//using System.Text;

//byte[] bytes = new byte[2];
////using FileStream fileStream = File.Open("hello.txt", FileMode.Open);
////long byteSize = fileStream.Length;
////for (int i = 0; i < byteSize; i += 2)
////{
////    fileStream.Read(bytes, 0, 2);
////    Console.WriteLine(Encoding.UTF8.GetString(bytes));
////}

//using (FileStream fileOp = File.Open("hello.txt", FileMode.Open))
//{
//    long n = fileOp.Length;
//    for (int i = 0; i < n; i+=2)
//    {
//        fileOp.Read(bytes, 0, 2);
//        Console.WriteLine(Encoding.UTF8.GetString(bytes));
//    }
//}

//Console.WriteLine(File.ReadAllText("hello.txt"));

string RootPath = Directory.GetCurrentDirectory();
Console.WriteLine(RootPath);
DirectoryInfo directoryInfo = new DirectoryInfo(RootPath);
Console.WriteLine(directoryInfo.Parent.Parent.Parent.FullName);
DirectoryInfo ProjectFolder = directoryInfo.Parent.Parent.Parent;
string newFolder = Path.Combine(ProjectFolder.FullName, "MyFolder");
if (!Directory.Exists(newFolder))
    Directory.CreateDirectory(newFolder);

DirectoryInfo[] folders = ProjectFolder.GetDirectories();
foreach(var folder in folders)
{
    Console.WriteLine(folder.FullName);
}