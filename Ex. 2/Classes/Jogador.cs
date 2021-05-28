using System;

namespace Ex._2.Classes
{
    public class Jogador
    {
        private string nome;
        public int dataNasc;
        private string nacionalidade;
        private double altura;
        private int peso;

        public void Cadastrar(){
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu ano de nascimento:");
            dataNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nacionalidade:");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite a sua altura:");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso:");
            peso = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Agradeçemos pelo seu preenchimento \n");
        }

        public void Listar(){
            Console.WriteLine($"Nome: {nome}");

            Console.WriteLine($" Ano de nascimento: {dataNasc}");

            Console.WriteLine($" Nacionalidade: {nacionalidade}");

            Console.WriteLine($"Altura: {altura}");

            Console.WriteLine($"Peso {peso}");
        }

        public void Cálculo()
        {
            int idade = DateTime.Now.Year - dataNasc;
            Console.WriteLine($"Você tem {idade} anos");
        }
    }


}