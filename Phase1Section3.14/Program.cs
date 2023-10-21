using System;
using System.IO;


namespace Section6PracticeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {// Path to the text file
            string filePath = "C:\\Users\\Admin\\source\\repos\\Phase1Section3.14\\Phase1Section3.14\\Student.txt";
            // Checks if the file exists
            if (File.Exists(filePath))
            {
                // Reads all lines from the file
                string[] lines = File.ReadAllLines(filePath);
                // Display the student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Student data file not found!");
            }
            Console.ReadLine();
        }
    }
}
