using System.Linq;

namespace HugoLand.Donnees
{
    public partial class CompteJoueur
    {
        public bool EstConnecte()
        {
            return Heros.Any(h => h.EstConnecte);
        }
    }
}