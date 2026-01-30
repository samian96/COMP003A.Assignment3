using System.ComponentModel;
using System.ComponentModel.Design;
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

            string input = (Console.ReadLine());

            int yOb;
            string category;

            if (!int.TryParse(input, out yOb))
            {
                category = "Invalid Input: Date of Birth must be written numerically";
            }
            else
            {
                int age = year - yOb;

                Console.WriteLine("Current Age:" + " " + age);

                if (age < 18)
                {
                    category = "Minor";
                }
                else
                {
                    category = "Adult";
                }
            }
            Console.WriteLine("Readiness Category:" + " " + category);
        }
    }
}
