using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var rx2018 = new TanqueInimigo();
            var r2d2 = new RoboInimigo();

            IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(r2d2);


            Console.WriteLine("=========== ROBO ===========");
            r2d2.ReagirContraHumano("Ricardo");
            r2d2.AndarFrente();
            r2d2.EsmagarComMaos();

            Console.WriteLine();
            Console.WriteLine("=========== TANQUE ===========");
            rx2018.Pilotar("Rafaela");
            rx2018.Movimenta();
            rx2018.ArmaFogo();

            Console.WriteLine();
            Console.WriteLine("=========== ROBO ADAPTER ===========");
            robo_adapter.Pilotar("Zeus");
            robo_adapter.Movimenta();
            robo_adapter.ArmaFogo();
        }
    }
}
