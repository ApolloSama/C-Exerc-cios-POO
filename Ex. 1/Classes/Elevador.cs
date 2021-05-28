using System;

namespace Ex._1.Classes
{
    public abstract class Elevador
    {
        private int andarAtual = 0;
        private int totalAndares;
        private int andar;
        private int capacidadeElevador;
        private int quantidadePessoas = 0;
        public int totalCaixas;


        public void Inicializar()
        {
            Console.WriteLine(@"
            
             .,-:;//;:=,
         . :H@@@MM@M#H/.,+%;,
      ,/X+ +M@@M@MM%=,-%HMMM@X/,
     -+@MM; $M@@MH+-,;XMMMM@MMMM@+-
    ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.                Seja bem vindo ao sistema de elevadores Aperture. Para configurar
  ,%MM@@MH ,@%=            .---=-=:=,.                preencha as informações de acordo com o que deseja.         
  -@#@@@MX .,              -%HX$$%%%+;               
 =-./@M@M$                  .;@MMMM@MM:
 X@/ -$MM/                    .+MM@@@M$
,@M@H: :@:                    . -X#@@@@-
,@@@MMX, .                    /H- ;@M@M=
.H@@@@M@+,                    %MM+..%#$.
 /MMMM@MMH/.                  XM@MH; -;
  /%+%$XHH@$=              , .H@@@@MX,
   .=--------.           -%H.,@@@@@MX,
   .%MM@@@HHHXX$$$%+- .:$MMX -M@@MM%.
     =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=
       =%@M@M#@$-.=$@MM@@@M; %M%=
         ,:+$+-,/H#MMMMMMM@- -,
               =++%%%%+/:-.
             ");

            Console.WriteLine("\nQual é a capacidade de pessoas do seu elevador?");
            capacidadeElevador = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("\nQual é a capacidade de caixas do seu elevador?");
            totalCaixas = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Quantos andares tem seu apartamento?");
            totalAndares = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Configurando...");
            Console.WriteLine("Agradeçemos por usar nosso sistema.");
        }


        public void Entrar()
        {
            if (quantidadePessoas < capacidadeElevador)
            {
            Console.WriteLine("um espaço foi ocupado");
            quantidadePessoas++;
            }
            else
            {
                Console.WriteLine("O elevador está cheio");
            }
        }
        public void Sair()
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("um espaço foi esvaziado");
                quantidadePessoas--;
            }
            else
            {
                Console.WriteLine("Não há ninguém no elevador");
            }
        }
        public void Subir()
        {
            Console.WriteLine("Para qual andar deseja subir?");
            andar = int.Parse(Console.ReadLine().ToLower());
            if (andar > andarAtual && andar <= totalAndares)
            {
                Console.WriteLine($"Você subiu até o {andar}º andar");
            }
            else { Console.WriteLine("Andar inválido"); }
        }
        public void Descer()
        {
            Console.WriteLine("Para qual andar deseja descer?");
            andar = int.Parse(Console.ReadLine().ToLower());
            if (andar < andarAtual && andar >= 0)
            {
                Console.WriteLine($"Você desceu até o {andar}º andar");
            }
            else { Console.WriteLine("Andar inválido"); }
        }
    }
}