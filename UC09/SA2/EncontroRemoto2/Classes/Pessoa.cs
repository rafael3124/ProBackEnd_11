using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncontroRemoto2.Interfaces;

namespace EncontroRemoto2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public float Rendimento { get; set; }

        public abstract float PagarImposto(float rendimento);

    }
}