using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class MondeEntiteDepot : EntiteDepot<Monde>
    {
        protected override DbSet<Monde> Entites => Contexte.Mondes;

        public MondeEntiteDepot(Entities contexte) : base(contexte)
        {
        }
    }
}