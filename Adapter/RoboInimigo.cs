using System;

namespace Adapter
{
    public class RoboInimigo
    {
        //o robo inimigo e o nosso objeto a ser adapitado
        private Func<int, int> Gerador = fator 
            => new Random().Next(fator) + 1;

        public void EsmagarComMaos()
            => Console.WriteLine($"{Gerador(10)} esta no controle do tanque!");

        public void AndarFrente()
            => Console.WriteLine($"O robo inimigo andou {Gerador(10)} para frente!");

        public void ReagirContraHumano(string piloto)
            => Console.WriteLine($"O robo inimigo vai contra o piloto {piloto}");
    }
}