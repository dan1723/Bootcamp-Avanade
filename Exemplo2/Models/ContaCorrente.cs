using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int NumeroConta, decimal saldo)
        {
            this.NumeroConta = NumeroConta;
            this.saldo = saldo;   
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                Console.WriteLine($"O seu saldo anterior era de R${saldo} reais");
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine($"O seu saldo atual é de R${saldo} reais");
            } 
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void ExiberSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é: " + saldo);
        }
    }
    
}