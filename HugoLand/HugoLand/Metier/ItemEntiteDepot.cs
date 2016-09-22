using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class ItemEntiteDepot : EntiteDepot<Item>
    {
        protected override DbSet<Item> Entites => Contexte.Items;

        public ItemEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public void ModifierQuantite(Item item, int quantite)
        {
            item.Quantite = quantite;

            Modifier(item);
        }

    }
}
