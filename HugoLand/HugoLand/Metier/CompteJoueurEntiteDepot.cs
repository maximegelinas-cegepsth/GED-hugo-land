using System.Collections.Generic;
using System.Data.Entity;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public class CompteJoueurEntiteDepot : EntiteDepot<CompteJoueur>
    {
        protected override DbSet<CompteJoueur> Entites => Contexte.CompteJoueurs;

        public CompteJoueurEntiteDepot(Entities contexte) : base(contexte)
        {
        }

        public IEnumerable<Hero> ObtenirHeros(CompteJoueur joueur)
        {
            return joueur.Heros;
        }
    }
}
