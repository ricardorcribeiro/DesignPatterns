using System;

//padrao facade e incarregado de carregar seus sub sistemas no casa dar new em todo mundo que ela chama
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new FacaseClass();
            facade.MertodoA();
            facade.MertodoB();
        }
    }
}
