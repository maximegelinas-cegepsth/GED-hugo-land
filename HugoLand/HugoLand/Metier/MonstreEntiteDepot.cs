using System.Data.Entity;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class MonstreEntiteDepot : EntiteDepot<Monstre>
    {
        protected override DbSet<Monstre> Entites => Contexte.Monstres;

        public MonstreEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public Monstre Ajouter(Monde monde)
        {
            return Contexte.Monstres.Add(new Monstre(monde));
        }
    }
}
