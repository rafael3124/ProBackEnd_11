using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncontroRemoto2.Interfaces;

namespace EncontroRemoto2.Classes
{
    //classe PessoaFisica que herda da classe abstrata e de sua Interface
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        //atributos
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        //método herdado como sobrescrita da classe abstrata
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        //méto herdado da interface IPessoaFisica
        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
    }
}