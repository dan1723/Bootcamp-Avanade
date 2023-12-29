using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class Pessoa
    {
        public Pessoa (string Nome)
        {
            this.Nome = Nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos!");
        }
    }
}