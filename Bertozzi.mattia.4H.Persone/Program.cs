using System;
using Bertozzi.mattia._4H.Persone.Models;

namespace Bertozzi.mattia._4H.Persone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Persone di Mattia Bertozzi");

            //persone disponibili nel vettore 3
            Persona People = new Persona();

            Persona People2 = new Persona();

            Console.WriteLine("Inserire cognome 1a persona");
            People.Cognome = Console.ReadLine();
            Console.WriteLine("Inserire nome 1a persona");
            People.Nome = Console.ReadLine();
            Console.WriteLine("Inserire eta 1a persona");
            string streta = Console.ReadLine();
            int eta = Convert.ToInt32(streta);
            People.Eta = eta;
            Console.WriteLine("\n");

            Console.WriteLine("Inserire cognome 2a persona");
            People2.Cognome = Console.ReadLine();
            Console.WriteLine("Inserire nome 2a persona");
            People2.Nome = Console.ReadLine();
            Console.WriteLine("Inserire eta 2a persona");
            string streta2 = Console.ReadLine();
            int eta2 = Convert.ToInt32(streta2);
            People2.Eta = eta2;
            Console.WriteLine("\n");

            Console.WriteLine("Dati Anagrafici eta 1a persona");
            Console.WriteLine(People.StampaAnagrafica());
            Console.WriteLine("\n");
            Console.WriteLine("Dati Anagrafici eta 2a persona");
            Console.WriteLine(People2.StampaAnagrafica());

            Console.WriteLine("\n");

            //per confornto
            if (People==People2)
            {
                Console.WriteLine("Le 2 persone sono coetanee");
            }
            else if (People > People2)
            {
                Console.WriteLine("La persona:");
                Console.WriteLine("\n");
                Console.WriteLine(People2.StampaAnagrafica());
                Console.WriteLine("\n");
                Console.WriteLine("è più giovane");
            }
            else if (People < People2)
            {
                Console.WriteLine("La persona:");
                Console.WriteLine(People.StampaAnagrafica());
                Console.WriteLine("è più giovane");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Vuoi modificare l'eta della '1'a o '2'a persona?");
            string scelta = Console.ReadLine();
            if(scelta=="1")
            {
                People.ModificaEta();
            }
            else if(scelta == "2")
            {
                People2.ModificaEta();
            }

            Console.WriteLine("Eta Modificata");

        }
    }
}
