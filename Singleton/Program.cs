using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("jogador 1: a bola esta comigo");
            
            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("jogador 2: recebeu a bola");
            
            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("jogador 3: recebeu lançamento na linha de");
            
            BolaSemSingleton jogador_4 = new BolaSemSingleton();
            jogador_1.Mensagem("jogador 4: a bola esta comigo");
            
            BolaSemSingleton jogador_5 = new BolaSemSingleton();
            jogador_2.Mensagem("jogador 5: recebeu a bola");
            
            BolaSemSingleton jogador_6 = new BolaSemSingleton();
            jogador_3.Mensagem("jogador 6: recebeu lançamento na linha de");
        }
    }
}
