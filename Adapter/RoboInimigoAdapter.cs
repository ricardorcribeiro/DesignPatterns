namespace Adapter
{
    //e o nosso objeto adaptador
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo RoboInimigo;

        public RoboInimigoAdapter(RoboInimigo robo)
        {
            RoboInimigo = robo;
        }

        public void ArmaFogo()
            => RoboInimigo.EsmagarComMaos();

        public void Movimenta()
            => RoboInimigo.AndarFrente();

        public void Pilotar(string piloto)
            => RoboInimigo.ReagirContraHumano(piloto);
    }
}