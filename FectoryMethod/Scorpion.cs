using System;

namespace FectoryMethod
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
            => Console.WriteLine(nameof(Scorpion));
    }
}