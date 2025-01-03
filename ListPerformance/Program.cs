using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        // допустим файлик лежит на рабочем столе
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "input.txt";
        string filePath = Path.Combine(desktopPath, fileName);

        List<string> textList = new List<string>();

        Stopwatch sw = Stopwatch.StartNew();

        try
        {
            while (true) { }
        }
        catch (Exception ex) { }

        Console.WriteLine("тут будет че то умное");
}
}