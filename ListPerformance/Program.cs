﻿using System.Diagnostics;

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
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                { 
                    textList.Add(line);
                }
            }
        }
        catch (Exception ex) 
        { 
            Console.WriteLine($"exeption: {ex.ToString()}");
        }

        Console.WriteLine($"{textList.Count} elements in {sw.ElapsedMilliseconds} ms");
}
}