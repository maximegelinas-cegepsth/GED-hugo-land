using System;
using System.Collections.Generic;

namespace HugoLand.Donnees
{
    public partial class Monstre
    {
        public Monstre()
        {
            var rnd = new Random();
            var noms = new[]
            {
                "Brinewraith",
                "Blazetaur",
                "Bonescreamer",
                "Mournling",
                "Vaporbug",
                "Metalbeast",
                "Vilesnake",
                "Dreadsword"
            };

            Nom = noms[rnd.Next(noms.Length)];
            Niveau = rnd.Next(1, 100);
            StatPV = rnd.Next(100, 1000);
            StatDmgMin = rnd.Next(1, 100);
            StatDmgMax = StatDmgMin + rnd.Next(1, 100);
        }

        public Monstre(Monde monde) : this()
        {
            var rnd = new Random();

            MondeId = monde.Id;
            x = rnd.Next(monde.LimiteX);
            y = rnd.Next(monde.LimiteY);
        }
    }
}
