using Fiap.Exercicio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.Models
{
    internal class ContaPoupanca : Conta, IContaInvestimento
    {
        public ContaPoupanca(int agencia, int numero, IList<Cliente> clientes, decimal taxa) : base(agencia, numero, clientes)
        {
            Taxa = taxa;
        }
        public decimal Taxa { get; set; }



        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * 0.04m;
        }

       

        public override void Retirar(decimal valor)
        {
            //Validar se pode realizar a retirada
            var valorDoSaque = valor + Taxa;
            if(valorDoSaque > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}
