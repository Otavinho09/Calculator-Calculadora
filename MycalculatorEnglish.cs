using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_sozinha_parte_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n1, n2, Result, sinal1;

            Console.WriteLine("\nChoose which math operation you want to do:\n");
                Console.WriteLine("1- + (Addition)\n2- - (Subtraction)\n3- x (Multiplication)\n4- : (Division)\n5- (Potentiation)\n");
                sinal1 = int.Parse(Console.ReadLine());
            
            do
            {

                if (sinal1 > 5 || sinal1 == 0)
                {
                    Console.WriteLine("You must to choose one of the options above:\n");
                    sinal1 = int.Parse(Console.ReadLine());
                }

            } while (sinal1 > 5);

            if (sinal1 < 5)
            {
                Console.WriteLine("Enter one nubmer");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Now, enter another number");
                n2 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter the number base to potentiate\n");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the expotent");
                n2 = int.Parse(Console.ReadLine());

            }
            if (sinal1 == 1)
            {
                Result = n1 + n2;
                Console.WriteLine(n1 + "+" + n2 + " = " + Result);
            }
            else if (sinal1 == 2)
            {
                Result = n1 - n2;
                Console.WriteLine(n1 + "-" + n2 + " = " + Result);
            }
            else if (sinal1 == 3)
            {
                Result = n1 * n2;
                Console.WriteLine(n1 + "*" + n2 + " = " + Result);
            }
            else if (sinal1 == 4)
            {
                Result = n1 / n2;
                Console.WriteLine(n1 + "/" + n2 + " = " +Result);
            }
            else if (sinal1 == 5) 
            {
                int counter = 1;
                int limit = n2;
                Result = n1;
                if (limit > 1)
                {
                    do
                    {

                        Result = n1 * Result;
                        counter++;

                    }while(counter < limit);
                }
                

                Console.WriteLine(n1+"to the" +n2+ "th power"+" = "+Result);
                
            }
            Console.ReadLine();
        }
    }
}
