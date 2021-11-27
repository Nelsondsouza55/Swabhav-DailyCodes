using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ReadFile();
            Console.ReadLine();
        }

        public static void CreateFile()
        {
            FileStream file = new FileStream("C:/Users/norbert paul d'souza/Desktop/csharpfile.txt", FileMode.Create);
            file.Close();
            Console.Write("File has been created and the Path is C:/Users/norbert paul d'souza/Desktop/csharpfile.txt");
        }

        public static void WriteFile()
        {
            string file = @"C:/Users/norbert paul d'souza/Desktop/csharpfile.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Hello");
                writer.WriteLine("Hi");
                writer.WriteLine("Writing this file");
            }
            Console.WriteLine("Data Saved Successfully!");
        }

        public static void ReadFile()
        {
            string file = @"C:/Users/norbert paul d'souza/Desktop/csharpfile.txt";           
            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
