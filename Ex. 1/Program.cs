using System;
using Ex._1.Classes;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;

            ElevadorSocial es = new ElevadorSocial();
            ElevadorServiço esv = new ElevadorServiço();

            es.Inicializar();

            Console.WriteLine("Qual elevador deseja usar? 1 (serviço) 2(social)");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                do
            {

                Console.WriteLine(@"
            O que deseja fazer?
            0. Adicionar Caixa
            1. Remover Caixa
            2. Entrar
            3. Sair
            4. Subir
            5. Descer
            6. Sair do sistema
            ");
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "0":
                        esv.AddCaixas();
                        break;
                    case "1":
                        esv.RmvCaixas();
                        break;
                    case "2":
                        esv.Entrar();
                        break;
                    case "3":
                        esv.Sair();
                        break;
                    case "4":
                        esv.Subir();
                        break;
                    case "5":
                        esv.Descer();
                        break;
                    case "6":
                        Console.WriteLine("Tenha um bom dia");
                        break;
                    default:
                        break;
                }
            } while (escolha != "6");
                    break;

                case "2":
                    do
                    {

                        Console.WriteLine(@"
            O que deseja fazer?
            1. Entrar
            2. Sair
            3. Subir
            4. Descer
            5. Sair do sistema
            ");
                        escolha = Console.ReadLine();
                        switch (escolha)
                        {
                            case "1":
                                es.Entrar();
                                break;
                            case "2":
                                es.Sair();
                                break;
                            case "3":
                                es.Subir();
                                break;
                            case "4":
                                es.Descer();
                                break;
                            case "5":
                                Console.WriteLine("Tenha um bom dia");
                                break;
                            default:
                                break;
                        }
                    } while (escolha != "5");
                    break;

                default:
                    break;
            }


        }
    }
}
