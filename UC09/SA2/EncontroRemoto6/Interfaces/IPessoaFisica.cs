using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime dataNascimento);
    }
}