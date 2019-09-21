using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Componente
    {
        public Composite(string nome) : base(nome)
        {
        }

        public List<Componente> Filhos = new List<Componente>();

        public override void Adicionar(Componente c)
            => Filhos.Add(c);

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine($"-{profundidade} {Nome}");

            Filhos.ForEach(x=> x.Mostrar(profundidade + 2));
        }

        public override void Remover(Componente c)
            => Filhos.Remove(c);
    }
}