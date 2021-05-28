using System;

namespace Ex._3.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;
        public int acucar = 10;
        public string escolha;

        public void Fazercafe(int quantAcucar)
        {
            acucarDisponivel = acucarDisponivel - quantAcucar;
            Console.WriteLine($"Seu café está feito com {quantAcucar}g de açúcar");
            if (acucarDisponivel <= 0)
            {
                acucarDisponivel = 0;
                Console.WriteLine("Não há mais açúcar nesta máquina");
            }
            Console.WriteLine(acucarDisponivel);

        }

        public void Fazercafe()
        {
            acucarDisponivel = acucarDisponivel - acucar;
            Console.WriteLine("Tá feito");
            Console.WriteLine(acucarDisponivel);
            if (acucarDisponivel <= 0)
            {
                acucarDisponivel = 0;
                Console.WriteLine("Não há mais açúcar nesta máquina");
            }

        }
        public void Fazercafe(string semAcucar)
        {
            Console.WriteLine("Tá feito");
            Console.WriteLine(acucarDisponivel);

        }
    }
}