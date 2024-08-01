using Serialization_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    [Serializable]
    internal class Employee2
    {
        public int Id;
        public string Name;
        public Employee2(int Id,string Name) 
        {
            this.Id = Id;   
            this.Name = Name;
        }

        //parameterless constructor for deserialization
        public Employee2() { }
    }
}







