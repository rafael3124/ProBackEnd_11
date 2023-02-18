using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto2.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}