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
            if (rendimento <= 1500){
                return 0;
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return rendimento * 0.02f;
            }
            else if(rendimento > 3500 && rendimento < 6000){
                return rendimento * 0.035f;
            }
            else{
                return rendimento * 0.05f;
            }
            
        }

        //méto herdado da interface IPessoaFisica
        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual =  DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            if (anos >= 18 )
            {
                return true;
            }
            return false;
        }

        public bool ValidarDataNascimento(string dataNascimento)
        {
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNascimento, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;
           
                if (anos >= 18 )
                {
                    return true;
                }
                return false;
            }
            return false;
        }


    
    }
}