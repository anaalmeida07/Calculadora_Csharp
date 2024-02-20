using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4-Divisão");

          

            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int n2 = int.Parse(Console.ReadLine());

            int result=0;

             switch (op)
             {
                 case 1:
                    {
                        result = Adicao(n1, n2);
                        break;
                    }
                   
                 case 2:
                    {
                        result = Subtracao(n1, n2);
                        break;
                    }
                     
                case 3:
                    {
                        result = Mult(n1, n2);
                        break;
                    }
                    
                case 4:
                    {
                        result = Div(n1, n2);
                        break;
                    }
                    
                 default:
                    Console.WriteLine("Numero inválido, digite outro numero!");
                     break;
             }
            Console.WriteLine("O resultado da operação com {0} e {1} é: {2}", n1, n2, result);
            Console.ReadLine();

        }
        public static int Adicao(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }

        public static int Subtracao(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }

        public static int Mult(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }

        public static int Div(int n1, int n2)
        {
            int result = n1 / n2;
            return result;
        }

    }
}
