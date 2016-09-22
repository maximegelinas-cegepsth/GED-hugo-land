using System;
using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class EffetItemEntiteDepot : EntiteDepot<EffetItem>
    {
        protected override DbSet<EffetItem> Entites => Contexte.EffetItems;

        public EffetItemEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public void Ajouter(EffetItem effet, Item item)
        {
            if (!Contexte.Items.Any(i => i.Id == item.Id)) throw new ArgumentException();

            effet.Item = item;

            Ajouter(effet);
        }

        public void Supprimer(EffetItem effet, Item item)
        {
            if (!Contexte.Items.Any(i => i.Id == item.Id)) throw new ArgumentException();

            Supprimer(effet);
        }

        public void Modifier(EffetItem effet, Item item)
        {
            if (!Contexte.Items.Any(i => i.Id == item.Id)) throw new ArgumentException();

            effet.Item = item;

            Modifier(effet);
        }
    }
}
