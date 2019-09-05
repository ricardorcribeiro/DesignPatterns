using System;

namespace FectoryMethod
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
            => Console.WriteLine(nameof(SubZero));
    }
}