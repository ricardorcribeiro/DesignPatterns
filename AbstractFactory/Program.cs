using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = ExecutaAbstractFactory.Escolha("luxo");
            Console.WriteLine($"tipo da roda: {carro.Roda.GetType()}");
            Console.WriteLine($"tipo da som: {carro.Som.GetType()}");
        }
    }
}
