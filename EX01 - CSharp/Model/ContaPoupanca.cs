using EX01___CSharp.Exception;
using EX01___CSharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Atributos
        private readonly decimal _rendimento;

        //Propriedades
        public decimal Taxa { get; set; }

        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        //Métodos
        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor + Taxa;
            return Saldo;
        }

    }
}
