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
            Functions functions = new Functions();

            //1. Write a function that takes in a list of strings and returns a copy of the list without duplicates.

            List<string> words = new List<string>() { "cat", "cat","dog", "dog", "dog", "dog", "bird" };
            words = functions.RemoveDuplictes(words);
            words.ForEach((x) => { Console.WriteLine(x);});
            Console.ReadLine();

            //2. Write a function that calculates the class grade average after dropping the lowest grade for each student.That is:
            //Write a function that takes in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.

            List<string> grades = new List<string>();
            grades.Add("70,20,30,40,50,60,70");
            grades.Add("80,20,30,40,50,60,70");
            grades.Add("100,20,30,40,50,60,70");
            grades.Add("90,20,30,40,50,60,70");
            double averages = functions.DropAndAverage(grades);
            Console.WriteLine(averages);
            Console.ReadLine(); 



        }
    }
}
//target = orig.ConvertAll(x => new TargetType { SomeValue = x.SomeValue });

//2. Write a function that calculates the class grade average after dropping the lowest grade for each student.That is:
//Write a function that takes in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.

//3. Write a function that takes in a string of letters (e.g., "Llewellyn") and returns a alphabetically ordered string corresponding to the letter frequency(e.g., "E2L4N1W1Y1")