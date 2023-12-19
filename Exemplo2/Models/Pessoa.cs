using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class Pessoa
    {
          
        public Pessoa(){

        }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int idade;

         
        public string Nome { 
            
            get => _nome.ToUpper();
            
            
            set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }


        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 
            
            get => idade;
            
            
            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor do que 0");
                }

                idade = value;
            } 
             
             
             
             }

        public void Apresentar(){

            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, eu tenho {Idade} anos");
        }
    }
}