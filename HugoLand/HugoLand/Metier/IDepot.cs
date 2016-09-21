using System.Collections.Generic;

namespace HugoLand.Metier
{
    public interface IDepot<T>
    {
        IEnumerable<T> ObtenirTous();

        T Ajouter(T entite);

        void Supprimer(int entiteId);

        void Supprimer(T entite);

        void Modifier(T entite);

        void SauvegarderChangements();
    }
}
