using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "cat", "cat","dog", "dog", "dog", "dog", "bird" };
            List<string> sortedWords;

            sortedWords = words.Distinct().ToList();
            sortedWords.ForEach((x) => { Console.WriteLine(x);});
            Console.ReadLine();
        }
    }
}

