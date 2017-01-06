using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tasks
{
    class Functions
    {
        public List<string> RemoveDuplictes(List<string>toClean)
        {
            List<string>sortedWords = toClean.Distinct().ToList();
            return sortedWords;
        }
        public double DropAndAverage(List<string> grades)
        {
            List<double> averages = new List<double>();
            foreach (string s in grades)
            {
                List<int>cleanedGrades = s.Split(',').Select(y => y.Trim()).ToList().ConvertAll(x => Int32.Parse(x));
                cleanedGrades.Sort();
                cleanedGrades.RemoveAt(0);
                averages.Add(cleanedGrades.Average());
            }
            double average = Math.Round(averages.Average(), 2, MidpointRounding.AwayFromZero);
            return average;
        }
        public string NumberName(string fruits)
        {
            List<string> countedLetters = new List<string>();
            List<int> counts = new List<int>();
            List<string> letters = fruits.ToCharArray().Select(x => x.ToString()).ToList();
            letters.Sort();
            List<string> cleanedLetters = letters.Distinct().ToList();
            var groups = letters.GroupBy(z => z);
            foreach (var group in groups)
            {
                countedLetters.Add(group.Key);
                countedLetters.Add(group.Count().ToString());
            }
            string result = String.Join("",countedLetters);
            return result;


            //foreach (string s in letters)
            //{
            //    int count = letters.Count(x => s == x);
            //    letters.RemoveRange(0, count-1);
            //    counts.Add(count);
            //}
            //var countedLetters = counts.Zip(letters, (first,second) => first+second);
        }
    }
}
//count = mylist.Count(s => myString.Contains(s));
//var count = test.Count(x => x == '&');
