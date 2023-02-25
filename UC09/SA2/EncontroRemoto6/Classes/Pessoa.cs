using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    //classe abstrata que herda de sua interface
    public abstract class Pessoa : IPessoa
    {
        //atributos
        public string? Nome { get; set; }
        public Endereco? Endereco { get; set; }
        public float Rendimento { get; set; }

        //método abstrato herdado da interface
        public abstract float PagarImposto(float rendimento);

    }
}