using System;
using System.Collections.Generic;
using System.Linq;

{
    public class Operations
{
    public double Addition(double a, double b)
    {
        return a + b;
    }
}

    class Program
    {
        static void Main(string[] args)
        {

            Operations oper = new Operations();
            while (true)
            {
                Console.WriteLine("***Здравейте! ТОВА Е МОЯТ ПРОЕКТ КАЛКУЛАТОР***");
                Console.WriteLine("МОЛЯ, ИЗБЕРЕТЕ ОПЦИЯ:\n" +
                                           "1 за калкулатор\n" +
                                       "2 за ДДС калкулатор\n" +
                                                   "0 за Изход");

                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Console.WriteLine("Избрахте калкулатор.");
                        Console.WriteLine("Моля, изберете операция!\n"
                           "1. За събиране --> +\n"
                            "2. За изваждане --> -\n");
                           string operation = Console.ReadLine();
                            
                            if (operation == "+")
                        {
                        Console.Write("First number: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Second number: ");
                        double b = double.Parse(Console.ReadLine());

                            oper.

                        }
                        break;
                    case 2:
                        Console.WriteLine("Избрахте ДДС калкулатор .");
                        break;
                    case 0:
                        Console.WriteLine("Изход.");
                        return;
                    default:
                        Console.WriteLine("Невалидна команда!");
                        break;
                }
            }
        }
    }
}

