using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {

        //Propriedades
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public Conta()
        {

        }

        //Métodos
        public abstract decimal Depositar(decimal valor);

        public abstract decimal Retirar(decimal valor);

    }
}
