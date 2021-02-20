using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate in 'Metric' or 'Imperial'?");
            string answer = Console.ReadLine();

            if (answer == "metric" || answer == "Metric")
            {
                try
                {
                    Console.WriteLine("What's your weight in kg?");
                    string weight = Console.ReadLine();
                    Console.WriteLine("What's your height in cm?");
                    string height = Console.ReadLine();

                    double Weight = Convert.ToDouble(weight);
                    double Height = Convert.ToDouble(height);
                    double BMI = (Weight/Height/Height)*10000;

                    if (BMI > 18.5 && BMI < 25)
                    {
                        Console.WriteLine("Your BMI is {0}.", BMI);
                        Console.WriteLine("You are within the ideal weight range.");
                    }
                    else if (BMI <= 18.5)
                    {
                        Console.WriteLine("Your BMI is {0}.", BMI);
                        Console.WriteLine("You are underweight.");
                    }
                    else
                    {
                        Console.WriteLine("Your BMI is {0}.", BMI);
                        Console.WriteLine("You are overweight. You should contact a doctor.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (answer == "Imperial" || answer == "imperial")
            {
                Console.WriteLine("What's your weight?");
                string weight = Console.ReadLine();
                Console.WriteLine("Do you want to enter your height in inches or feet?");
                string InchesVsFeet = Console.ReadLine();
                if (InchesVsFeet == "inches" || InchesVsFeet == "Inches")
                {
                    try
                    {
                        Console.WriteLine("What's your height?");
                        string height = Console.ReadLine();

                        double Weight = Convert.ToDouble(weight);
                        double Height = Convert.ToDouble(height);
                        double BMI = (Weight / (Height * Height) * 703);

                        if (BMI > 18.5 && BMI < 25)
                        {
                            Console.WriteLine("Your BMI is {0}.", BMI);
                            Console.WriteLine("You are within the ideal weight range.");
                        }
                        else if (BMI <= 18.5)
                        {
                            Console.WriteLine("Your BMI is {0}.", BMI);
                            Console.WriteLine("You are underweight.");
                        }
                        else
                        {
                            Console.WriteLine("Your BMI is {0}.", BMI);
                            Console.WriteLine("You are overweight. You should contact a doctor.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if (InchesVsFeet == "Feet" || InchesVsFeet == "feet")
                {
                    try
                    {
                        Console.WriteLine("What's your height?");
                        string height = Console.ReadLine();

                        double Weight = Convert.ToDouble(weight);
                        double Height = Convert.ToDouble(height);
                        double ConvertToInches = Height * 12;

                        double BMI = (Weight / (ConvertToInches * ConvertToInches) * 703);

                        if (BMI > 18.5 && BMI < 25)
                        {
                            Console.WriteLine("Your BMI is {0}.", BMI);
                            Console.WriteLine("You are within the ideal weight range.");
                        }
                        else if (BMI <= 18.5)
                        {
                            Console.WriteLine("Your BMI is {0}.", BMI);
                            Console.WriteLine("You are underweight.");
                        }
                        else
                        {
                            Console.WriteLine("Your BMI is {0}.", BMI);
                            Console.WriteLine("You are overweight. You should contact a doctor.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
