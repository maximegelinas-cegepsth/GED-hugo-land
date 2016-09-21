using System.Data.Entity;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class ObjectMondeEntiteDepot : EntiteDepot<ObjetMonde>
    {
        protected override DbSet<ObjetMonde> Entites => Contexte.ObjetMondes;

        public ObjectMondeEntiteDepot(Entities contexte) : base(contexte)
        {
        }
    }
}