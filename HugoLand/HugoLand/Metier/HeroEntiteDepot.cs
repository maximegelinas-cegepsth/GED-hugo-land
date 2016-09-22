using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class HeroEntiteDepot : EntiteDepot<Hero>
    {
        protected override DbSet<Hero> Entites => Contexte.Heros;

        public HeroEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public Classe ObtenirClasse(Hero hero)
        {
            return hero.Classe;
        }

        public Tuple<IEnumerable<ObjetMonde>, IEnumerable<Monstre>, IEnumerable<Item>, IEnumerable<Hero>> ObtenirElementsAProximite(Hero hero)
        {
            var objetsMonde =
                Contexte.ObjetMondes.Where(x => x.Monde == hero.Monde && hero.x - 100 <= x.x && x.x <= hero.x + 100 && hero.y - 100 <= x.y && x.x <= hero.y + 100);
            var monstres =
                Contexte.Monstres.Where(x => x.Monde == hero.Monde && hero.x - 100 <= x.x && x.x <= hero.x + 100 && hero.y - 100 <= x.y && x.x <= hero.y + 100);
            var items =
                Contexte.Items.Where(x => x.Monde == hero.Monde && hero.x - 100 <= x.x && x.x <= hero.x + 100 && hero.y - 100 <= x.y && x.x <= hero.y + 100);
            var heros =
                Contexte.Heros.Where(x => x.Monde == hero.Monde && hero.x - 100 <= x.x && x.x <= hero.x + 100 && hero.y - 100 <= x.y && x.x <= hero.y + 100);

            return new Tuple<IEnumerable<ObjetMonde>, IEnumerable<Monstre>, IEnumerable<Item>, IEnumerable<Hero>>(objetsMonde, monstres, items, heros);
        }
    }
}
