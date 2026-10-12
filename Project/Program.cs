using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***HELLO! THIS IS MY CALCULATOR PROJECT***");
                Console.WriteLine("Please choose one option!\n" +
                                           "1 for Calculator\n" +
                                       "2 for VAT Calculator\n" +
                                                   "0 for Exit");

                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Console.WriteLine("Calculator selected.");
                        break;
                    case 2:
                        Console.WriteLine("VAT calculator selected.");
                        break;
                    case 0:
                        Console.WriteLine("Exit.");
                        return;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
    }
}

