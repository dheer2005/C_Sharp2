using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Employee1
    {
        public int emp_id1
        {
            get;
            set;
        }

        public string emp_name1
        {
            get;
            set;
        }
        public string emp_lang1
        {
            get;   
            set;
        }
    }

    class Program
    {
        //Employees class
        List<Employee1> emp1 = new List<Employee1>()
            {
                new Employee1 { emp_id1 = 209, emp_name1 = "Soniya",emp_lang1 = "C#"},
                new Employee1 { emp_id1 = 210, emp_name1 = "Raja",emp_lang1 = "C"},
                new Employee1 { emp_id1 = 211, emp_name1 = "Anjita",emp_lang1 = "Java"}

            };

        List<Employee2> emp2 = new List<Employee2>()
            {
                new Employee2(){emp_id2 = 290, emp_name2 = "Rohit" ,emp_lang2 = "C#"},
                new Employee2(){emp_id2 = 291, emp_name2 = "Ronak" ,emp_lang2 = "Python"},
                new Employee2(){emp_id2 = 292, emp_name2 = "Ravi" ,emp_lang2 = "Java"}

            };

        var result = emp1.Select(e => e.emp_lang1).Union(emp2.Select(e => e.emp_lang2));

        Console.WriteLine("Common Languages : ");

            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
}
}
