using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime dataNascimento);
    }
}