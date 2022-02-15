using System;

namespace Desafio_14_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           "Jogo do chute", o usuário tem que acertar o número
           aleatório escolhido pelo computador, ao acertar o computador 
           imprime na tela o número de chutes que foram necessários.
       */

            int qtd_chutes = 1;

            while (true)
            {
                Console.Write("Digite um numero (entre 0-100): ");
                int chute = int.Parse(Console.ReadLine());

                if (chute > 45)
                {
                    Console.WriteLine("Seu chute foi muito alto...");
                }
                else if (chute < 45)
                {
                    Console.WriteLine("Seu chute foi muito baixo...");
                }
                else
                {
                    break;
                }
                qtd_chutes += 1;
            }
            Console.WriteLine($"Você acertou o numero em {qtd_chutes} tentativas!");
        }
    }
}
