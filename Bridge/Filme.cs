namespace Bridge
{
    public class Filme : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no: canal de filmes";
        }

        public string Status()
        {
            return "voce esta assinstindo - os vingadores";
        }
    }
}