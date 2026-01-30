using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = DateTime.Now.Year;

            Console.WriteLine("=== Academic & Personal Readiness Evaluator ===");

            Console.WriteLine("\n");

            Console.WriteLine("Current Year:" + year);

            Console.Write("Please enter your birth year: ");

            int yOb = int.Parse(Console.ReadLine());

            int age = year - yOb;

            string category;

            Console.WriteLine("Current Age:" + " " + age);

            Console.WriteLine("Readiness Category:" + " " + category);
        }
    }
}
