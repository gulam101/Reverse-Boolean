using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Boolean
{
    class Program
    {
       public static void Main(string[] args)
        {
            MainFunction();
        }

        public static void MainFunction()
        {    
                Console.WriteLine("Welcome to reverse boolean");
                Console.Write("Please type in either true or false: ");
                bool userinput;

                try
                {
                    userinput = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine($"You have choosen: {userinput}");

                    if (userinput)
                    {
                        Console.WriteLine("This is false!");
                    
                     if (userinput)
                    {
                        Console.ReadLine();
                    }
                }
                    else if (!(userinput))
                    {
                        Console.WriteLine("This is true!");
                    }
                }
                catch
                {
                    Console.WriteLine("You haven't chosen a valid option");
                    MainFunction();
                }
                Console.ReadLine();          
        }
    }
}
