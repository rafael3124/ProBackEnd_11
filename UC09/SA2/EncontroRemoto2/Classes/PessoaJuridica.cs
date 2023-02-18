using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto2.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; init; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}