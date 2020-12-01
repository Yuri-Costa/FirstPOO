using System;

namespace FirstPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        //------------------Personagens-------------------
          Personagem jogador1 = new Personagem();
          jogador1.nome = "Yuri";
          jogador1.idade = 17;
          jogador1.elemento = "fogo";
          jogador1.poder = 88;
          
          
          //----------------------------------------------
         Personagem jogador2 = new Personagem();
          jogador2.nome = "wilabix";
          jogador2.idade = 89;
          jogador2.elemento = "Ar";
          jogador2.poder = 77;

          //-------------------------------------------------
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Olá, selecione o seu personagem:  Yuri/wilabix");
         Console.ForegroundColor= ConsoleColor.Magenta;
         Console.WriteLine("informações-----------------------------------------------------");
         Console.WriteLine($"NOME :     {jogador1.nome}     |NOME  :     {jogador2.nome}");
         Console.WriteLine($"IDADE :    {jogador1.idade}    |IDADE :     {jogador2.idade}");
         Console.WriteLine($"ELEMENTO : {jogador1.elemento} |ELEMENTO :  {jogador2.elemento}");
         Console.WriteLine($"PODER :    {jogador1.poder}    |PODER    :  {jogador2.poder}");
         Console.WriteLine("------------------------------------------------------------------");
            string escolha = Console.ReadLine();
        //---------------------------------------------------------
             Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"voce escolheu {escolha} como seu personagem!");

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("agora, selecione um personagem para lutar contra:  Yuri/wilabix");
            string contra = Console.ReadLine();
        //---------------------------------------------------------
          Console.ForegroundColor= ConsoleColor.Yellow;
         Console.WriteLine("-------------------------------------");
         Console.WriteLine($"a luta será {escolha} vs {contra}");
         Console.WriteLine("-------------------------------------");

          
           
           

          


        }
    }
}
