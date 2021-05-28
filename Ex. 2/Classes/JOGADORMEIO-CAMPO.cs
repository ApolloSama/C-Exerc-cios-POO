using System;

namespace Ex._2.Classes
{
    public class JOGADORMEIO_CAMPO : Jogador
    {
        public void Validação()
        {
            int idade = 2021 - dataNasc;
            if (idade >= 38)
            {
                Console.WriteLine("Você tem a possibilidade de se aposentar");
            }
            else
            {
                Console.WriteLine("Você ainda não pode se aposentar.");
            }
        }
    }
}