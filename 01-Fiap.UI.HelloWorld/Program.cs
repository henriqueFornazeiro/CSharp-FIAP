using _01_Fiap.UI.HelloWorld.Model;
using System;

namespace _01_Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciar um carro
            Carro carro = new Carro();
            carro.tipo = TipoCarro.Suv;
            // Atribuir um código ao carro
            carro.Codigo = 10;
            //Exibir o código do carro
            Console.WriteLine(carro.tipo);


            //Instanciar um carro 2
            Carro carro2 = new Carro()
            {
                nome = "fox",
                Marca = "Volks"
            };

        }
    }
}

