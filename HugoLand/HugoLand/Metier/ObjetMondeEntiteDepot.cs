using System;
using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class ObjectMondeEntiteDepot : EntiteDepot<ObjetMonde>
    {
        protected override DbSet<ObjetMonde> Entites => Contexte.ObjetMondes;

        public ObjectMondeEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public void ModifierDescription(ObjetMonde objetMonde, string description, Monde monde)
        {
            if (monde.ObjetMondes.All(o => o.Id != objetMonde.Id)) throw new ArgumentException();

            objetMonde.Description = description;

            Modifier(objetMonde);
        }
    }
}