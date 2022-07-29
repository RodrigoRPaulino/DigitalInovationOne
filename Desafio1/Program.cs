using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)


        {
            string frase;

            Console.WriteLine("Digite seu nome:");

            frase = Console.ReadLine();

            Console.WriteLine("Bem Vindo:" + frase);
            Console.WriteLine($"Escolha o valor maximo do numero aleatorio");
            int valorMax = int.Parse(Console.ReadLine());

            Random numeroAleatorio = new Random();
            int valorInteiro = numeroAleatorio.Next(0, valorMax);
            bool acertou = false;




            int quantidadeDeChutes = 1;
            while (quantidadeDeChutes <= 10)
            {
                Console.Write($"Digite um numero (entre 0 - {valorMax}):");
                int chute = int.Parse(Console.ReadLine());
                if (chute > valorInteiro)
                {
                    Console.WriteLine("Seu chute foi muito alto...");

                }
                else if (chute < valorInteiro)
                {
                    Console.WriteLine("Seu chute foi muito baixo...");


                }
                else
                {
                    Console.WriteLine($" Parabens {frase } ! Voce acertou o numero {quantidadeDeChutes} tentativas !");
                    acertou = true;

                    break;

                }

                quantidadeDeChutes++;




            }
            if (acertou)
            {
                Console.WriteLine($"Acertou o numero randomico é {valorInteiro}");
            }
            else
            {
                Console.WriteLine($"Voce errou ! o numero randomico era{valorInteiro}");
            }
        }
    }
}