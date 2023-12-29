using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class Professor : Pessoa
    {
        public Professor(string Nome) : base(Nome)
        {
            
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu sou um professor e minha idade é {Idade} anos, meu sálario é de R${Salario} reais");
        }
    }
}