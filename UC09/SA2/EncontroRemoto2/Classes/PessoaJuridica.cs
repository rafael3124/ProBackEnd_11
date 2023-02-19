using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncontroRemoto2.Interfaces;

namespace EncontroRemoto2.Classes
{
    //classe PessoaJuridica que herda da classe abstrata e de sua interface
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; init; }

        //método herdado como sobrescrita da classe abstrata
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        //método herdado da interface IPessoaJuridica
        public bool ValidarCnpj(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}