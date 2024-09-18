public class Program
{
    static void Main()
    {
        Task task = new Task(CallMethod);
        task.Start();
        task.Wait();

        Console.WriteLine("Complete");
    }

    static async void CallMethod()
    {
        var FolderPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
        var file1 = Path.Combine(FolderPath, "file1.txt");
        var file2 = Path.Combine(FolderPath, "file2.txt");
        
        Task<int>[] tasks = new Task<int>[2];
        tasks[0] = ReadFileAsync(file1);
        tasks[1] = ReadFileAsync(file2);

        Console.WriteLine("Work 1 Done");
        Console.WriteLine("Work 2 Done");
        Console.WriteLine("Work 3 Done");

        int[] lengths = await Task.WhenAll(tasks);
        Console.WriteLine("First File Length: "+lengths[0]);
        Console.WriteLine("Second File Length: "+lengths[1]);

        Console.WriteLine("After Work 1");
        Console.WriteLine("After Work 2");
    }

    static async Task<int> ReadFileAsync(string path)
    {
        var length = 0;
        Console.WriteLine("File Read Starting");
        using (var read = new StreamReader(path))
        {
            var s = await read.ReadToEndAsync();
            length = s.Length;
        }
        Console.WriteLine("File Read Complete");
        return length;
    }
}