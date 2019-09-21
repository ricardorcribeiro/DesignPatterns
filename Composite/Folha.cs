using System;

namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
        }

        public override void Adicionar(Componente c)
        {
            Console.WriteLine("nao foi possivel adicionar a folha");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine($"-{profundidade} {Nome}");
        }

        public override void Remover(Componente c)
        {
            throw new System.NotImplementedException();
        }
    }
}