using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HugoLand.Donnees;

namespace HugoLand.Metier
{
    public abstract class EntiteDepot<T> : IDepot<T> where T : class
    {
        protected readonly Entities Contexte;

        protected abstract DbSet<T> Entites { get; }

        internal EntiteDepot(Entities contexte)
        {
            Contexte = contexte;
        }

        public virtual IEnumerable<T> ObtenirTous()
        {
            return Entites.ToList();
        }

        public virtual T Ajouter(T entite)
        {
            return Entites.Add(entite);
        }

        public virtual void Supprimer(int entiteId)
        {
            var entite = Entites.Find(entiteId);
            Supprimer(entite);
        }

        public virtual void Supprimer(T entite)
        {
            Entites.Remove(entite);
        }

        public void Modifier(T entite)
        {
            Contexte.Entry(entite).State = EntityState.Modified;
        }

        public void SauvegarderChangements()
        {
            Contexte.SaveChanges();
        }
    }
}
