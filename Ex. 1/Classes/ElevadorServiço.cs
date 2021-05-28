using System;
namespace Ex._1.Classes
{
    public class ElevadorServiço : Elevador
    {
        private int quantidadeCaixas = 0;
        
        public void AddCaixas(){
            if (quantidadeCaixas < totalCaixas)
            {
                Console.WriteLine("foi colocada uma caixa");
                quantidadeCaixas++;
            } else Console.WriteLine("O elevador já está em sua capacidade máxima de caixas");
        }
        
        public void RmvCaixas(){
            if (quantidadeCaixas > 0 && quantidadeCaixas <= totalCaixas)
            {
                Console.WriteLine("foi colocada uma caixa");
                quantidadeCaixas++;
            } else
            {
                Console.WriteLine("Não há caixas no elevador");
            }
        }


    }

}