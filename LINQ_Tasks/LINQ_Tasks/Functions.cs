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
                List<string>cleanedGrades = s.Split(',').Select(y => y.Trim()).ToList();
                List<int>sortedGrades = cleanedGrades.ConvertAll(x => Int32.Parse(x));
                sortedGrades.Sort();
                sortedGrades.RemoveAt(0);
                averages.Add(sortedGrades.Average());
            }
            double average = Math.Round(averages.Average(), 2, MidpointRounding.AwayFromZero);
            return average;
        }
    }
}
