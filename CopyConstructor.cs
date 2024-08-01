using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    internal class CopyConstructor
    {
        string name;
        string age;

       public CopyConstructor(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public CopyConstructor(CopyConstructor copy)
        {
            this.name = copy.name;
            this.age = copy.age;
        }

        public void getData()
        {
            Console.WriteLine("Name is {0} and age is {0} ",name,age);
        }

        public static void main(string[] args)
        {
            CopyConstructor c = new CopyConstructor("Dheer", "19");
            c.getData();

        }
    }
}
