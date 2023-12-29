using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class Diretor : Professor
    {
        public Diretor(string Nome) : base(Nome)
        {
            
        }

        public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}