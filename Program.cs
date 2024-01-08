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
            Exercicio2();
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
        static void Exercicio1()
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
            int hora = DateTime.Now.Hour;

            Console.WriteLine("{0}", hora);

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
        static void Switch()
        {
            int hora = DateTime.Now.Hour;
            string mensagem = string.Empty;

            switch(hora)
            {
                case 6:
                    mensagem="Hora de começar";
                    break;
                case 10:
                case 15:
                    mensagem= "Hora do Intervalo";
                    break;
                case 12:
                    mensagem= "Almoço";
                    break;
                default:
                    mensagem= string.Empty;
                    break;
            }
            Console.WriteLine("{0}", mensagem);
            Console.ReadLine();
        }
        static void Exercicio2()
        {
            Console.Write("Qual o valor total da sua compra?");
            decimal valorCompra = Convert.ToDecimal(Console.ReadLine());
            int numeroParcelas = 3;
            decimal valorParcela = valorCompra / numeroParcelas;
            decimal valorMinimoParcelar = 1000.01m;

            if  (valorCompra >= valorMinimoParcelar)
            {
                Console.WriteLine("É possivel parcelar sua compra em até x3");
                Console.WriteLine("O valor da sua compra é {0:c} portanto o pagamente será x{1} de {2:c};", valorCompra, numeroParcelas , valorParcela);
            }
            else
            {
                Console.WriteLine("O valor da sua compra é {0:c} por isso o pagamento será à vista, x1 de {0:c}.", valorCompra);
            }

            Console.WriteLine("Obrigado e volte sempre!");
            Console.ReadLine();
        }
    }
}
