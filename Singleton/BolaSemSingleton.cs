using System;

namespace Singleton
{
    public class BolaSemSingleton
    {
        public BolaSemSingleton()
        {
            Mensagem("bola em jogo");
        }
        public void Mensagem(string msg)
            => Console.WriteLine(msg);
    }
}