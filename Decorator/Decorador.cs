namespace Decorator
{
    //ele e o decorator abstrato
    public class Decorador : ItemBiblioteca
    {
        protected ItemBiblioteca ItemBiblioteca;

        public Decorador(ItemBiblioteca itemBiblioteca)
        {
            ItemBiblioteca = itemBiblioteca;
        }

        public override void Exibe()
        {
            this.ItemBiblioteca.Exibe();
        }
    }
}