using System.Collections.Generic;
using System.Data.Entity;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class ClasseEntiteDepot : EntiteDepot<Classe>
    {
        protected override DbSet<Classe> Entites => Contexte.Classes;

        public ClasseEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public IEnumerable<Classe> ObtenirTousParMonde(Monde monde)
        {
            return monde.Classes;
        }
    }
}
