using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        // допустим файлик лежит на рабочем столе
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "input.txt";
        string filePath = Path.Combine(desktopPath, fileName);

        LinkedList<string> textLinkedList = new LinkedList<string>();

        Stopwatch sw = Stopwatch.StartNew();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textLinkedList.AddLast(line); 
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"exeption: {ex.ToString()}");
            return; // слышала тут ретерн вроде нужен, точно не помню
        }

        Console.WriteLine($"{textLinkedList.Count} elements in {sw.ElapsedMilliseconds} ms");
    }
}