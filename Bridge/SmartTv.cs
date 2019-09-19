using System;

namespace Bridge
{
    public class SmartTv
    {
        //bridge e o fato de ter um interface nao implementada dentro de uma classe concreta
        public ICanal CanalAtual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Canal());
            else
                Console.WriteLine("por favor selecione um canal");
        }

        public void PlayTv()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Status());
            else
                Console.WriteLine("por favor selecione um canal para assistir algo");
        }
    }
}