using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This section of logic determines the current year, as well as has user enter their birth year
            int year = DateTime.Now.Year;

            Console.WriteLine("=== Academic & Personal Readiness Evaluator ===");

            Console.WriteLine("\n");

            Console.WriteLine("Current Year:" + year);

            Console.Write("Please enter your birth year: ");

            string input = (Console.ReadLine());

            Console.WriteLine("\n");
            // this section of logic stops the console from crashing if invalid input by using try parse to convert string to value
            int yOb;
            string category;

            if (!int.TryParse(input, out yOb))
            {
                category = "Invalid Input: Date of Birth must be written numerically";
            }
            else
            {
             // If valid input this section subracts current year and birth year to determine age to display category
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

            Console.WriteLine("\n");
            // section to determine readiness status using bool conditions (yes/no)
            Console.Write("Do you have a valid ID? (yes/no): ");

            string validId = Console.ReadLine();

            Console.Write("Have you completed the Orientation? (yes/no): ");

            string orient = Console.ReadLine();

            string readiness;

            bool readinesslevel = validId.ToLower() == "yes";

            bool readinessLevel = orient.ToLower() == "yes";

            if (validId == "yes" && orient == "yes")
            {
                readiness = "Ready";
            }
            else if (validId != "yes" || orient != "yes")
            {
                readiness = "Conditionally Ready";
            }
            else
            {
                readiness = "Not Ready";
            }
        }
    }
}
