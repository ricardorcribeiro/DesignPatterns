using System;

namespace FectoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{nameof(LiuKang)} | {nameof(SubZero)} | {nameof(Scorpion)}");
            Console.WriteLine();
            Console.WriteLine("Escolha um personagem");
            var escolhido = Console.ReadLine();
            Console.WriteLine("personagem escolhido foi");
            FectoryMethod.EscolherPersonagem(escolhido).Escolhido();
        }
    }
}
