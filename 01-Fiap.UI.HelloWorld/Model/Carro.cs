using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Carro : Veiculo, IAutomatico
    {
        //Constructor
        public Carro(String nome) : base(nome)
        {
        }
        public Carro()
        {
        }

        public int Portas { get; set; }

        public decimal Valor { get; set; }


        public String Marca { get; set; }

        public TipoCarro tipo { get; set; }

        public override void Ligar()
        {
            Console.WriteLine("Carro ligado");
        }
        public override void Andar()
        {
            Console.WriteLine("Carro andando");
        }

        public void TrocarMarcha()
        {
            throw new NotImplementedException();
        }
    }
}
