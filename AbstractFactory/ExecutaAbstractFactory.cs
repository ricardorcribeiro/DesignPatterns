namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro Escolha(string escolha){
            
            CarroFactory fact = null;
            switch (escolha)
            {
                case "luxo":
                    fact = new CarroLuxoFactory();
                break;
                case "popular":
                fact = new CarroPopularFactory();
                break;
            }

            return new Carro{
                Roda = fact.MontarRoda(),
                Som = fact.MontarSom()
            };
        }
    }
}