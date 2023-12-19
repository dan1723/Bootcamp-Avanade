 using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class Curso
    {
         public string Nome { get; set; }
         public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){

            Alunos.Add(aluno);
        }

        public int QuantAluno(){

            int quant = Alunos.Count;
            return quant;
        }

        public bool RemoverAluno(Pessoa aluno){

            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){

            Console.WriteLine("Alunos do curso de Inglês:");

            for(int cont = 0; cont < Alunos.Count; cont++){

                //string text = "Nº" + cont + " - " + Alunos[cont].NomeCompleto;
                string text = $"Nº {cont + 1} - {Alunos[cont].NomeCompleto}";
                Console.WriteLine(text);
            }
        }   
    }
}