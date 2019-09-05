using System;

namespace FectoryMethod
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
            => Console.WriteLine(nameof(LiuKang));
        
    }
}