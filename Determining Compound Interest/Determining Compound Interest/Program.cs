using System;

namespace Determining_Compound_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the principal amount?");
            string amount = Console.ReadLine();
            Console.WriteLine("What is the rate?");
            string rate = Console.ReadLine();
            Console.WriteLine("What is the number of years");
            string years = Console.ReadLine();
            Console.WriteLine("What is the number of times the interest\nis compounded per year?");
            string compoundPerYear = Console.ReadLine();

            

            double Amount = Convert.ToDouble(amount);
            double Rate = Convert.ToDouble(rate);
            double Years = Convert.ToDouble(years);
            double CompoundPerYear = Convert.ToDouble(compoundPerYear);

            double EndOfInvestment = Amount * Math.Pow((1 + (Rate/100) / CompoundPerYear), CompoundPerYear * Years);

            Console.WriteLine("${0:F2} invested at {1:f2}% for {2} years\ncompounded {3} times per year is ${4:f2}.", Amount, Rate, Years, CompoundPerYear, EndOfInvestment);
        }
    }
}
