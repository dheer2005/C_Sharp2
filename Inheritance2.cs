using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;
    }

    class VisitingEmployees : Employees
    {
        public int VisitingSalary = 30;
        public int VisitingHours = 40;
    }

    class PermanentEmployees : Employees
    {
        public int PermanentSalary = 0;
        public int PermanentHours = 20;
    }

    public static void Main(string[] args)
    {
        PermanentEmployees Asad = new PermanentEmployees();
        Asad.EmpId = 19;
        VisitingEmployees Anil = new VisitingEmployees();
        Anil.EmpId = 20;
        Console.WriteLine(Asad.EmpId);
        Console.WriteLine(Anil.EmpId);
    }


}
