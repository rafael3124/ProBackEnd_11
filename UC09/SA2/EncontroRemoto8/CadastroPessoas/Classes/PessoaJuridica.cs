using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    //classe PessoaJuridica que herda da classe abstrata e de sua interface
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
        public string? Caminho {get; private set;} = "Database/PessoaJuridica.csv";

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

        //metodo para inserir um objeto de pessoa jurídica em um arquivo
        public void Inserir(PessoaJuridica pj)
        {   
            //chamada para verificar pasta do arquivo
            Utils.VerificarPastaArquivo(Caminho);

            //transforma os objetos em string
            string[] pjStrings = {$"{pj.Nome},{pj.Cnpj},{pj.RazaoSocial}"};

            //inserção dos itens como string dentro do aqquivo .csv
            File.AppendAllLines(Caminho,pjStrings);
        }

        public List<PessoaJuridica> LerArquivo()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];
                
                listaPj.Add(cadaPj);
            }
            return listaPj;
        }

    }
}

