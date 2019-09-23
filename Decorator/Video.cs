using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {

        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }

public Video(string diretor, string titulo, int minutosDuracao, int numeroCopias)
{
    Diretor = diretor;
    Titulo = titulo;
    MinutosDuracao = minutosDuracao;
    NumeroCopias = numeroCopias;
}

        public override void Exibe()
        {
            Console.WriteLine("\nLivro ----");
            Console.WriteLine($"diretor: {Diretor}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"MinutosDuracao: {MinutosDuracao}");
            Console.WriteLine($"NumeroCopias: {NumeroCopias}");

        }
    }
}