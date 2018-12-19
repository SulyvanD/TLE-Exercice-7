using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE___Exercice_7
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            // Affichage par boucle
            foreach (Week day in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine(day.ToString());
            }
            Console.WriteLine(Enum.GetNames(typeof(Week)).GetValue(4));

            // Affichage à la main
            Console.WriteLine(Week.Lundi);
            Console.WriteLine(Week.Mardi);
            Console.WriteLine(Week.Mercredi);
            Console.WriteLine(Week.Jeudi);
            Console.WriteLine(Week.Vendredi);
            Console.WriteLine(Week.Samedi);
            Console.WriteLine(Week.Dimanche);

            // Différentes techniques pour afficher l'index 4
            Console.WriteLine(Enum.GetNames(typeof(Week)).GetValue(4));
            Console.WriteLine(Enum.GetName(typeof(Week), 4));
            Console.WriteLine((Week)4);
        }
    }
}
