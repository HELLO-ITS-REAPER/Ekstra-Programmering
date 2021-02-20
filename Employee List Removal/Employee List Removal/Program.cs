using System;
using System.Collections.Generic;
using System.IO;

namespace Employee_List_Removal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Employees = new List<string>();
            Employees.Add("Martin");
            Employees.Add("Daniel");
            Employees.Add("Dorthe");
            Employees.Add("Kim");
            Employees.Add("Anders");

            Console.WriteLine("There are {0} employee(s):", Employees.Count);
            foreach (string name in Employees)
            {
                Console.WriteLine(name);
            }
            while (Employees.Count > 0)
            {
                Console.WriteLine("\nEnter an employee name to remove:");
                string removedEmployee = Console.ReadLine();
                if (Employees.Contains(removedEmployee))
                {
                    Employees.Remove(removedEmployee);
                    Console.WriteLine("\nThere are {0} employee(s):", Employees.Count);
                    foreach (string name in Employees)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine("There was not found an employee by the name {0}.", removedEmployee);
                }
            }

        }
    }
}
