using System;

namespace HugoLand.Donnees
{
    public partial class Hero
    {
        public void Deplacer(int positionX, int positionY)
        {
            if (0 <= positionX && positionX <= Monde.LimiteX) throw new ArgumentException();
            if (0 <= positionY && positionY <= Monde.LimiteY) throw new ArgumentException();

            x = positionX;
            y = positionY;
        }
    }
}