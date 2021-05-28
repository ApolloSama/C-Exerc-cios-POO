using System;

namespace Ex._2.Classes
{
    public class JOGADORATAQUE : Jogador
    {
        public void Validação()
        {
            int idade = 2021 - dataNasc;
            if (idade >= 35)
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