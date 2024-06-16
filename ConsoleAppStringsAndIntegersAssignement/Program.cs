using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DivisionApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                //list of integers
                List<int> numbers = new List<int> { 222, 345, 543, 888, 6789, 1234 };
                
                try
                {
                    Console.Write("Enter a number I can divide another number with: ");
                    //user input
                    string input = Console.ReadLine();
                    // Convert input to double
                    double divisor = double.Parse(input); 

                    foreach (int num in numbers)
                    { //iteration loop
                        double result = num / divisor;
                        Console.WriteLine($"{num} divided by {divisor} is {result}");
                    }
                }
                //exception handling
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an whole number.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please enter another number than zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally 
                //finishes try/catch and exits
                {
                    Console.WriteLine("Exited try/catch block. Will go to program exit.");
                }

                Console.WriteLine("Program has finished.");
                Console.ReadKey(); 
            }
        }
    }


