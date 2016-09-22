using System.Data.Entity;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class MondeEntiteDepot : EntiteDepot<Monde>
    {
        protected override DbSet<Monde> Entites => Contexte.Mondes;

        public MondeEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public void Modifier(Monde monde, int limiteX, int limiteY, string description)
        {
            monde.LimiteX = limiteX;
            monde.LimiteY = limiteY;
            monde.Description = description;

            Modifier(monde);
        }
    }
}