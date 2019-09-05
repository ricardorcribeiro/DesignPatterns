using System;

namespace FectoryMethod
{
    public class FectoryMethod
    {
        public static IPersonagem EscolherPersonagem(string tipo)
        {
            switch (tipo)
            {
                case nameof(LiuKang): return new LiuKang();
                case nameof(SubZero): return new SubZero();
                case nameof(Scorpion): return new Scorpion();
                default: return null;
            }
        }
    }
}