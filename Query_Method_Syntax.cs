using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Query__Method_Syntax
    {
        public static void Main(string[] args)
        {
            //Query syntax
            List<string> My_list = new List<string>()
            {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
            };

            var result = from l in My_list
                         where l.Contains("my")
                         select l;

            foreach (var l in result)
            {
                Console.WriteLine(l);
            }

            //method syntax
            List<string> my_list = new List<string>()
            {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
            };

            var result = my_list.Where(a => a.Contains("Dog"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        
}
}
