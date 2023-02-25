using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EncontroRemoto2.Interfaces;

namespace EncontroRemoto2.Classes
{
    //classe PessoaJuridica que herda da classe abstrata e de sua interface
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }

        //método herdado como sobrescrita da classe abstrata
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000){
                return rendimento * 0.03f;
            }
            else if (rendimento > 3000 && rendimento <= 6000){
                return rendimento * 0.05f;
            }
            else if (rendimento > 6000 && rendimento <10000){
                return rendimento * 0.07f;
            }
            else{
                return rendimento * 0.09f;
            }
        }


        //método herdado da interface IPessoaJuridica
        public bool ValidarCnpj(string cnpj)
        {
         if (Regex.IsMatch(cnpj, @"(^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                        {
                            return true;
                        }
                }
            }
            return false;
        }
        // padrão   58.566.555/0001-55 |||  58566555000155
    }
}