using HugoLand.Donnees;
using HugoLand.Metier;

namespace HugoLand
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contexte = new Entities();
            var mondeDepot = new MondeEntiteDepot(contexte);
            var monstreDepot = new MonstreEntiteDepot(contexte);

            var mondes = mondeDepot.ObtenirTous();

            monstreDepot.Supprimer(1);

            monstreDepot.Sauvegarder();
        }
    }

}