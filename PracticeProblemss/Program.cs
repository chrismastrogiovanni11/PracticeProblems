using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(w => w.Contains("th")).ToList();


            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var oneMike = names.Distinct().ToList();

            //Problem 3 //to separate each class list of grades use for each
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            foreach (var student in classGrades)
            {
                //double.Parse(Console.WriteLine(student));


                var studentGrades = student.Split(',').Select(s => double.Parse(s)).ToArray().Where(s =>s. )
                


            }
                

            

        }

        
    }
}
