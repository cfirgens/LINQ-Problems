using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class LinqPractice
    {
        //Using LINQ, write a function that returns all words that contain the substring “th” from a list
        public void ReturnTH()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var newList = words.Where(w => w.Contains("th"));
            foreach (string word in newList)
            {
                Console.WriteLine(word);
            }
        }

        //Using LINQ, write a function that takes in a list of strings and returns a copy of thelist without duplicates
        public void ReturnStringNoDuplicate()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            
            foreach (var name in names.Distinct())
            {
                Console.WriteLine(name);
            }
        }


    }
}
