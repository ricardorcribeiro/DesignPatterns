using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // criat um livro
            Livro livro = new Livro("ricardo","eu queria",30);

            livro.Exibe();

            // criar video
            Video video = new Video("rafaela", "o vento levou",120, 3);
            video.Exibe();

            // emprestar um video
            Console.WriteLine("\nfazendo um emprestimo");

            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("zeus");
            emprestado.EmprestarItem("gaia");

            emprestado.Exibe();

            emprestado.DevolvarItem("gaia");
            
            emprestado.Exibe();
        }
    }
}
