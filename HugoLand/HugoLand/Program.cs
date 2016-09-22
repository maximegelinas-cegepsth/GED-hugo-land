using System;
using System.Linq;
using HugoLand.Donnees;
using HugoLand.Metier;
using HugoLand.Presentation;

namespace HugoLand
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contexte = new Entities();
            var mondeContexte = new MondeEntiteDepot(contexte);

            var mondes = mondeContexte.ObtenirTous();

            Afficheur.AfficherEtat(mondes.First());

            Console.ReadKey();
        }
    }

}