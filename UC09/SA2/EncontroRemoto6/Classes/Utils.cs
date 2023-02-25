using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Classes
{
    public class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(texto);
            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }
    }
}