using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Vogel> VogelListe = new List<Vogel>();

            //VogelListe.Add(new Vogel("Raab"));
            //VogelListe.Add(new Vogel("Amsel"));
            //VogelListe.Add(new Vogel("Papagei"));

            //foreach(Vogel vogel in VogelListe)
            //{
            //    vogel.PrintTierTyp();
            //    Console.WriteLine(vogel.Name);
            //}

            List<Tier> TierListe = new List<Tier>();

            TierListe.Add(new Schaf("Schaf1"));
            TierListe.Add(new Tiger("Tiger1"));
            TierListe.Add(new Vogel("Raab"));
            TierListe.Add(new Schaf("Schaf2"));

            foreach(Tier tier in TierListe)
            {
                tier.PrintTierTyp();
                Console.WriteLine(tier.Name);
            }


        }
    }
}
