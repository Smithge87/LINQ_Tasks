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

            List<string> grades = new List<string>() { "20", "10", "30", "40", "50", "60", "70", "80", "90", "100" };
            List<int> gradesCleaned;

            gradesCleaned = grades.ConvertAll(x => Int32.Parse(x));
            gradesCleaned.Sort();
            gradesCleaned.RemoveAt(0);
            double average = gradesCleaned.Average();
            //gradesCleaned.ForEach((x) => { Console.WriteLine(x); });
            Console.WriteLine("\n"+average);
            Console.ReadLine();

            List<string> moreGrades = new List<string>();
            List<string> cleanedGrades = new List<string>();
            moreGrades.Add("70,20,30,40,50,60,70");
            moreGrades.Add("80,20,30,40,50,60,70");
            moreGrades.Add("100,20,30,40,50,60,70");
            moreGrades.Add("90,20,30,40,50,60,70");
            List<string> sortedGrades = new List<string>();


            foreach (string s in moreGrades)
            {
                cleanedGrades = s.Split(',').Select(y => y.Trim()).ToList();
                sortedGrades.AddRange(cleanedGrades);
                sortedGrades.Sort();
                sortedGrades.ConvertAll(x => Int32.Parse(x));
                sortedGrades.RemoveAt(0);
            }
            
            Console.ReadLine();



        }
    }
}
//target = orig.ConvertAll(x => new TargetType { SomeValue = x.SomeValue });
//1. Write a function that takes in a list of strings and returns a copy of the list without duplicates.

//2. Write a function that calculates the class grade average after dropping the lowest grade for each student.That is:
//Write a function that takes in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.

//3. Write a function that takes in a string of letters (e.g., "Llewellyn") and returns a alphabetically ordered string corresponding to the letter frequency(e.g., "E2L4N1W1Y1")