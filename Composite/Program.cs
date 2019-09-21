using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Adicionar(new Folha("folha a"));
            root.Adicionar(new Folha("folha b"));

            Composite comp = new Composite("componente x");
            comp.Adicionar(new Folha("folha xa"));
            comp.Adicionar(new Folha("folha xb"));

            root.Adicionar(comp);
            root.Adicionar(new Folha("folha c"));

            Folha folha = new Folha("folha d");
            root.Adicionar(folha);
            root.Remover(folha);

            root.Mostrar(1);
        }
    }
}


