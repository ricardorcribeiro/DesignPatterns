using System;
namespace Facade
{
    public class FacaseClass
    {
        private SubSistemaUm um;
        private SubSistemaDois dois;
        private SubSistemaTres tres;

        public FacaseClass()
        {
            um = new SubSistemaUm();
            dois = new SubSistemaDois();
            tres = new SubSistemaTres();
        }

        public void MertodoA(){
            Console.WriteLine("\n metodoA() --------");
            dois.MetodoDois();
            tres.MetodoTres();
        }

        public void MertodoB(){
            Console.WriteLine("\n metodoB() --------");
            um.MetodoUm();
            tres.MetodoTres();
        }
    }
}