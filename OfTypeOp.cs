using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class OfTypeOp
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_gender { get; set; }
        public string emp_hiredate { get; set; }
        public int emp_salary {  get; set; }

    }

    class program
    {
        public static void Main(string[] args)
        {
            //OfTypeOp
            ArrayList emp = new ArrayList();
            emp.Add(new OfTypeOp { emp_id = 209, emp_name = "Anjita" });
            emp.Add(new OfTypeOp { emp_id = 210, emp_name = "Soniya" });
            emp.Add(new OfTypeOp { emp_id = 211, emp_name = "Rohan" });

            var result = emp.OfType<OfTypeOp>();

            foreach (var item in result)
            {
                Console.WriteLine("Employee Id is : {0} ", item.emp_id);
            }
        }
    }
}
