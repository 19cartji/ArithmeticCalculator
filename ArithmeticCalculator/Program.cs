// Jillian Carter 9/15/17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
                
            while (true) 
            { 
                //Prompt the user for a number
                Console.WriteLine("Enter a number or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                
                        //Prompt the user for an operation
                        Console.WriteLine("Enter an operation +, -, /, or * : ");
                        var choice = Console.ReadLine();
                   
                            Console.WriteLine("Enter another number or type \"quit\" to exit: ");
                            var entry2 = Console.ReadLine();

                            var input1 = double.Parse(entry);
                            var input2 = double.Parse(entry2);

                            if (choice == "+")
                            {
                                Console.WriteLine(input1 + input2);
                            }
                            else if (choice == "-")
                            {
                                Console.WriteLine(input1 - input2);
                            }
                            else if (choice == "/")
                            {
                                Console.WriteLine(input1 / input2);
                            }
                            else if (choice == "*")
                            {
                                Console.WriteLine(input1 * input2);
                            }
                
            }
          
        }
    }
}
