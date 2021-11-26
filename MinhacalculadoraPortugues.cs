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
            int n1, n2, Resultado, sinal1;

            Console.WriteLine("\nEscolha qual operação matematica você quer:\n");
                Console.WriteLine("1- + (Adição)\n2- - (Subtração)\n3- x (Multiplicação)\n4- : (Divisão)\n5- (Potenciação)\n");
                sinal1 = int.Parse(Console.ReadLine());
            
            do
            {

                if (sinal1 > 5 || sinal1 == 0)
                {
                    Console.WriteLine("Voce deve escolher uma das opcoes acima");
                    sinal1 = int.Parse(Console.ReadLine());
                }

            } while (sinal1 > 5);

            if (sinal1 < 5)
            {
                Console.WriteLine("Digite um número");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora, digite outro número");
                n2 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Digite o numero que deseja fazer a potenciação\n");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a potencia que voce deseja elevar");
                n2 = int.Parse(Console.ReadLine());

            }
            if (sinal1 == 1)
            {
                Resultado = n1 + n2;
                Console.WriteLine(n1 + "+" + n2 + " = " + Resultado);
            }
            else if (sinal1 == 2)
            {
                Resultado = n1 - n2;
                Console.WriteLine(n1 + "-" + n2 + " = " + Resultado);
            }
            else if (sinal1 == 3)
            {
                Resultado = n1 * n2;
                Console.WriteLine(n1 + "*" + n2 + " = " + Resultado);
            }
            else if (sinal1 == 4)
            {
                Resultado = n1 / n2;
                Console.WriteLine(n1 + "/" + n2 + " = " +Resultado);
            }
            else if (sinal1 == 5) 
            {
                int cont = 1;
                int limite = n2;
                Resultado = n1;
                if (limite > 1)
                {
                    do
                    {

                        Resultado = n1 * Resultado;
                        cont++;

                    }while(cont < limite);
                }
                

                Console.WriteLine(n1 + "Elevado na" + n2 + "potencia" + Resultado);
                
            }
            Console.ReadLine();
        }
    }
}
