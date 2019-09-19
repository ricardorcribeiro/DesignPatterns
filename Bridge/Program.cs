using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv minhaTv = new SmartTv();

            Console.WriteLine("selecione um canal");
            Console.WriteLine("1 - filmes");
            Console.WriteLine("2 - documentarios");
            Console.WriteLine("3 - culinaria");

            ConsoleKeyInfo impout = Console.ReadKey();

            switch (impout.KeyChar)
            {
                case '1':
                    minhaTv.CanalAtual = new Filme();
                    break;
                case '2':
                    minhaTv.CanalAtual = new Documentario();
                    break;
                case '3':
                    minhaTv.CanalAtual = new Culinaria();
                    break;
            }

            minhaTv.ExibeCanalSintonizado();
            minhaTv.PlayTv();
        }
    }
}
