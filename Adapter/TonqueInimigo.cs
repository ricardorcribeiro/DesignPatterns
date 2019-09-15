using System;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random Gerador = new Random();

        public void ArmaFogo()
            => Console.WriteLine($"Ataque inimigo fez {Gerador.Next(10) + 1} de dano!");

        public void Movimenta()
            => Console.WriteLine($"Ataque inimigo andou {Gerador.Next(5) + 1} espaços!");

        public void Pilotar(string piloto)
            => Console.WriteLine($"{piloto} esta no controle do tanque!");
    }
}