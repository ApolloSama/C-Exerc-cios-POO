using System;
using System.Threading;
using Ex._3.Classes;
namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe M = new MaquinaCafe();


            string escolha;
            int quantAcucar;

            Console.WriteLine("Bem vindo ao sistema CafeteiraTabajaras Plus++");
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Console.WriteLine("Perdão, é um pouco lento");
            Thread.Sleep(2200);

            do
            {
                Console.WriteLine(@"
                ________._________
                |      | \   -   /
                |  ||  |  \  -  /       Deseja fazer seu café com açúcar (1) ou sem açúcar (2)?
                |  ||  |___\___/
                |  ||  |     X
                |      |    ___
                |      |   / - \
                |______|  /  -  \
                | ____ | /_______\
                ||Taba||__________
                ||____|           |
                |_________________|
            ");
                escolha = Console.ReadLine().ToLower();

                if (escolha == "1")
                {
                    Console.WriteLine("quer sua propria quantia de açúcar (1) ou a quantia padrão (2)?");
                    escolha = Console.ReadLine().ToLower();
                    switch (escolha)
                    {
                        case "1":
                            Console.WriteLine("Quanto açúcar quer colocar?");
                            quantAcucar = int.Parse(Console.ReadLine().ToLower());
                            if (quantAcucar <= M.acucarDisponivel)
                            {
                                M.Fazercafe(quantAcucar);
                            }
                            break;

                        case "2":
                            M.Fazercafe();
                            break;

                        default:
                            break;
                    }

                }
                else if (escolha == "2")
                {

                    M.Fazercafe("SemAçúcar");
                }
            } while (M.acucarDisponivel > 0);


            Console.WriteLine("Sua máquina está sem açúcar, só lhe resta fazer café sem açúcar");
            do
            {
                if (M.acucarDisponivel <= 0)
                {
                    Console.WriteLine("Deseja fazer seu café? (S/N)");
                    escolha = Console.ReadLine().ToLower();

                    switch (escolha)
                    {
                        case "s":
                            M.Fazercafe("SemAçúcar");
                            break;

                        case "n":
                            Console.WriteLine("Agradecemos por usar o sistema CafeteiraTabajaras Plus++");
                            break;

                        default:
                            break;
                    }
                }

            } while (escolha != "n");


        }
    }
}
