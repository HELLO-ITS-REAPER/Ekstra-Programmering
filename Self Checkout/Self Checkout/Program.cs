using System;

namespace Self_Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price of item 1:");
            string price1 = Console.ReadLine();
            Console.WriteLine("Enter the quantity of item 1:");
            string quantity1 = Console.ReadLine();
            Console.WriteLine("Enter the price of item 2:");
            string price2 = Console.ReadLine();
            Console.WriteLine("Enter the quantity of item 2:");
            string quantity2 = Console.ReadLine();
            Console.WriteLine("Enter the price of item 3:");
            string price3 = Console.ReadLine();
            Console.WriteLine("Enter the quantity of item 3:");
            string quantity3 = Console.ReadLine();
            

            decimal p1 = Convert.ToDecimal(price1);
            int q1 = Convert.ToInt32(quantity1);
            decimal p2 = Convert.ToDecimal(price2);
            int q2 = Convert.ToInt32(quantity2);
            decimal p3 = Convert.ToDecimal(price3);
            int q3 = Convert.ToInt32(quantity3);


            decimal subtotal = (p1*q1 + p2*q2 + p3*q3);
            decimal taxConverter = Convert.ToDecimal(5.5/100);
            decimal tax = subtotal * taxConverter;
            decimal total = subtotal + tax;

            
            Console.WriteLine("Subtotal: \t${0:f2}", subtotal);
            Console.WriteLine("Tax: \t\t${0:f2}", tax);
            Console.WriteLine("Total: \t\t${0:f2}", total);
            Console.ReadLine();
        }
    }
}
