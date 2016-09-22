using System;
using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class InventaireHeroEntiteDepot : EntiteDepot<InventaireHero>
    {
        protected override DbSet<InventaireHero> Entites => Contexte.InventaireHeroes;

        public InventaireHeroEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public void AjouterItem(Item item, Hero hero)
        {
            item.x = 0;
            item.y = 0;

            hero.InventaireHeroes.Add(new InventaireHero()
            {
                Item = item
            });
        }

        public void SupprimerItem(Item item, Hero hero)
        {
            var rdn = new Random();
            item.x = rdn.Next(item.Monde.LimiteX);
            item.y = rdn.Next(item.Monde.LimiteY);

            var inventaireHero = hero.InventaireHeroes.First(i => i.Item == item);

            Supprimer(inventaireHero);
        }
    }
}
