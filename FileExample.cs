using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fundamentals
{
    internal class FileExample
    {
        public static void main(string[] args)
        {
           /* FileInfo fo = new FileInfo("d://myfile.txt");
            FileStream fs = fo.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome in file handlling program");
            sw.Close();
            Console.WriteLine("File created Successfully");
           */

            //for read data
            
            FileInfo fo = new FileInfo("d://myfile.txt");
            FileStream fs = new FileStream(fo.FullName, FileMode.Open);
            StreamReader sr = new StreamReader(fs); 
            String data = sr.ReadToEnd();
            Console.WriteLine(data);
           

            //Appent text into the file
           /* FileInfo fo = new FileInfo("d://myfile.txt");
            using (StreamWriter sw = fo.AppendText())
            {
                sw.WriteLine("Welcome to test Record");

            }
           */

            }
        }
}
