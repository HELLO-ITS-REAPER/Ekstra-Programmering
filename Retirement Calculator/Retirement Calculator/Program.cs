using System;

namespace Retirement_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int retirement;

            Console.WriteLine("What is your current age?");
            string ageInput = Console.ReadLine();
            age = Convert.ToInt32(ageInput);
            
            Console.WriteLine("At what age would you like to retire?");
            string retirementAge = Console.ReadLine();
            retirement = Convert.ToInt32(retirementAge);

            int yearsLeft = (retirement - age);
            int currentYear = DateTime.Now.Year;
            int retirementYear = (DateTime.Now.Year + yearsLeft);
            if (age < retirement)
            {
                Console.WriteLine("You have {0} years left until you can retire.", yearsLeft);
                Console.WriteLine("It's {0}, so you can retire in {1}", currentYear, retirementYear);
                Console.ReadLine();
            }
            else if (age > retirement)
            {
                Console.WriteLine("You could retire {0} year(s) ago.", -yearsLeft);
                Console.WriteLine("It's {0}, so you could retire {1} year(s) ago.", currentYear, retirementYear);
                Console.ReadLine();
            }
        }
    }
}
