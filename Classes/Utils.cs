using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATIV_UC12_SA2_ER2.Classes
{
   public static class Utils
    {
        public static void BarraCarregamento (string texto, int qtdPontinhos, int tempo ) // Classes static podem sem chamadas diretamente, não precisando ser instanciadas
        {
            Console.BackgroundColor = ConsoleColor.Yellow;// Altera a cor de fundo
            Console.ForegroundColor = ConsoleColor.White;//Altera a cor da fonte
            Console.Write($"{texto}");

            for (int contador = 1; contador <= qtdPontinhos; contador ++)
            {
                Console.Write(".");
                Thread.Sleep(tempo); //Aguarda meio segundo
            }
            Console.ResetColor(); //Volta as cores de fundo e fonte para o padrão
            System.Console.WriteLine(); // Pular uma linha
        }

        public static void ParadaNoConsole(string txt)
        {
             //Fazer parada no sistema
            Console.WriteLine(txt);
            Console.WriteLine($"Tecle ENTER para continuar...");
            Console.ReadLine();
        }


       

    }
}