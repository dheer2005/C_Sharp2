using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    internal class JsonSerialize
    {
        /* //binary Serialization
            *//*string path = @"D:\\Serailization_DemoFile\sample.txt";
            Employee emp = new Employee(241, "Dheer");
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine("File created Successfully -> " + path);*/

        /* //JSON Serialization

             string path = @"D:\Serailization_DemoFile\sample1.json";
             Employee2 emp = new Employee(242, "Raja");

             // Serialize to JSON
             string jsonString = JsonSerializer.Serialize(emp);

             // Write JSON to file
             File.WriteAllText(path, jsonString);

             Console.WriteLine("File created Successfully -> " + path);*/

        // Optional: Demonstrate deserialization
        string path = @"D:\Serailization_DemoFile\sample1.json";
        Employee2 emp = new Employee(242, "Raja");
        string readJson = File.ReadAllText(path);
        Employee deserializedEmp = JsonSerializer.Deserialize<Employee>(readJson);
        Console.WriteLine("Deserialized: ID = " + deserializedEmp.Id);
            Console.WriteLine("Deserialized Name = " + deserializedEmp.Name);
        }
}
}
