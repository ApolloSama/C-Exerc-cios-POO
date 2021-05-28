using System;
using Ex._2.Classes;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            bool validacao = false;

            Jogador J = new Jogador();
            JOGADORATAQUE JA = new JOGADORATAQUE();
            JOGADORDEFESA JD = new JOGADORDEFESA();
            JOGADORMEIO_CAMPO JM = new JOGADORMEIO_CAMPO();

            Console.WriteLine("Bem vindo ao sistema aposentador de jogadores de futebolismo!");

            Console.WriteLine("Para prosseguir, cadastre-se primeiro.");
            J.Cadastrar();

            Console.WriteLine(2021 - J.dataNasc);

            do
            {
                Console.WriteLine(@"Para calcularmos, precisamos que você especifique a sua posição como jogador:
            1. Atacante
            2. Defesa
            3. Meio-Campo
            ");
                escolha = Console.ReadLine().ToLower();
                if (escolha == "1" || escolha == "2" || escolha == "3")
                {
                    validacao = true;
                }

                J.Cálculo();

                switch (escolha)
                {
                    case "1":
                        JA.Validação();
                        validacao = true;
                        break;

                    case "2":
                        JD.Validação();
                        validacao = true;
                        break;

                    case "3":
                        JM.Validação();
                        validacao = true;
                        break;

                    default:
                        break;
                }
            } while (validacao == false);
        }

    }
}
