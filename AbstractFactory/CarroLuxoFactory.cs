namespace AbstractFactory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRoda()
            => new RodaLigaLeve();

        public override Som MontarSom()
            => new BluetoohPlayer();
    }
}