using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args) // Método: Main
        {
            If();
        }

        static void ExemploSoma()
        {
            int x;
            int y;

            Console.Write("Digite um numero:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero:");
            y = Convert.ToInt32(Console.ReadLine());

            int soma = x + y;

            Console.WriteLine("A soma entre {0} e {1} é {2}", x, y, soma);
            Console.ReadLine();
        }
        static void ExemploMultiplicacao()
        {
            Console.WriteLine("Digite o valor do produto:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quantidade:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            decimal total = quantidade * valor;

            Console.WriteLine("O total da sua compra é {0:c}", total);
            Console.ReadLine();
        }
        static void Exercicio()
        {
            Console.WriteLine("Qual o valor da compra?");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual o numero de parcelas?");
            short parcelas = Convert.ToInt16(Console.ReadLine());

            decimal valorParcela = valor/parcelas;

            Console.WriteLine("O valor de cada parcela será {0:c}", valorParcela);
        }
        static void If()
        {
            Console.WriteLine("Digite um numero entre 1 e 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n<1 || n>10)
            {
                Console.WriteLine("O numero digitado não está entre 1 e 10");
            }
            else
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
