using System;
using System.Collections.Generic;

namespace Decorator
{
    //ele e o decorator concreto
    public class Emprestado : Decorador
    {

        protected List<string> Emprestados = new List<string>();

        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {

        }

        public void EmprestarItem(string nome)
        {
            Emprestados.Add(nome);
            ItemBiblioteca.NumeroCopias--;
        }
        public void DevolvarItem(string nome)
        {
            Emprestados.Remove(nome);
            ItemBiblioteca.NumeroCopias++;
        }
        public override void Exibe()
        {
            base.Exibe();
            Emprestados.ForEach(x => Console.WriteLine($"emprestados: {x}"));
        }

    }
}