using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace HugoLand.Presentation
{
    public static class Afficheur
    {
        public static void AfficherEtat<T>(T obj)
        {
            
            Console.WriteLine("==================================================================");
            Console.WriteLine($"  {typeof(T).Name}");
            Console.WriteLine("------------------------------------------------------------------");
            foreach (PropertyDescriptor descripteur in TypeDescriptor.GetProperties(obj))
            {
                var nom = descripteur.Name;
                var valeur = descripteur.GetValue(obj);
                if (valeur is IEnumerable)
                {
                    valeur = "[...]";
                }
                var separation = "";
                while (separation.Length < 20 - nom.Length)
                {
                    separation += " ";
                }
                Console.WriteLine($"\t{nom}{separation}: {valeur}");
            }
            Console.WriteLine("==================================================================");
            Console.Write("\n");
        }
    }
}
