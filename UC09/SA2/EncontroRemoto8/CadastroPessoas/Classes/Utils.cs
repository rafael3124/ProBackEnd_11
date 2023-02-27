using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Classes
{
    public class Utils
    {
        //método barra de carregamento
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
        //Método para verificar se o caminho existe "Database/PessoaJuridica.csv"
        public static void VerificarPastaArquivo(string caminho)
        {
            //variavel que vai receber a posição 0 do caminho ("Database")
            string pasta = caminho.Split("/")[0];
            //cria a pasta se não existir
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            //cria o arquivo caso não exista
            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}