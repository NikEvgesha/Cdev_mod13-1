﻿
using System.Diagnostics;
namespace Cdev_mod13;
class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine(Environment.CurrentDirectory.Replace("\\bin\\Debug\\net6.0", ""), "cdev-text.txt");
        
        Stopwatch stopwatch = new Stopwatch();
        string text = File.ReadAllText(filePath);
        char[] delimiters = new char[] { ' ', '\r', '\n' };
        var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        List<string> list = new List<string>();
        LinkedList<string>  linkedList = new LinkedList<string>();

        stopwatch.Start();
        foreach (string word in words)
        {
            list.Add(word);
        }
        stopwatch.Stop();
        Console.WriteLine("Runtime for list: " + stopwatch.Elapsed);

        stopwatch.Restart();
        foreach (string word in linkedList) 
        { 
            linkedList.AddLast(word);
        }
        stopwatch.Stop();
        Console.WriteLine("Runtime for linked list: " + stopwatch.Elapsed);
    }

}