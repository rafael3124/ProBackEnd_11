using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Classes
{
    public class Endereco
    {
        public string? Logradouro { get; set; }

        public int Numero { get; set; }
    
        public string? Complemento { get; set; }

        public bool Comercial { get; set; }
    }
}