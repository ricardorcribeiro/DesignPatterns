namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no: canal de documentario";
        }

        public string Status()
        {
            return "voce esta assinstindo - a origem de tudo";
        }
    }
}