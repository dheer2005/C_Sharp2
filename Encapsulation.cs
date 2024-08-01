using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Encapsulation
    {
        private string name;
        private int Id;

        public Encapsulation()
        {
            name = "test";
            Id = 111;
        }
        public Encapsulation(string name, int id) 
        {
            this.name = name;
            this.Id = id;
        }

        public void Display()
        {
            Console.WriteLine("Student name is {0} and Student Id is {1}", name, Id);
        }
    }

    public class program
    {
        public static void Main(string[] args) 
        { 
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Display();

            Encapsulation encapsulation1 = new Encapsulation("Raghav",222);
            encapsulation1.Display();
        }
}
