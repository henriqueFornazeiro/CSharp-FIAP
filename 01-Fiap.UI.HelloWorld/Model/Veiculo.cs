using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    abstract class Veiculo
    {

        //Metodos
        public abstract void Ligar();

        public virtual void Andar()
        {
            Console.WriteLine("Veiculo em movimento");
        }

        public Veiculo(string nome)
        {
            this.nome = nome;
        }
        public Veiculo()
        {

        }
        //Atributos - Fields/Campos
        private int _codigo;

        //Métodos - Gets/Sets
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }

        }

        public string nome { get; set; }



    }
}
