using System;
using System.Collections.Generic;
using System.Text;

namespace Bertozzi.mattia._4H.Persone.Models
{
    class Persona
    {
        private string _cognome;
        private string _nome;
        private int _eta;

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value; 
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }

        public string VediNome()
        {
            return $"Nome:{_nome}";
        }

        public string VediCognome()
        {
            return $"Cognome:{_cognome}";
        }

        public string VediEta()
        {
            return $"Eta:{_eta}";
        }

        public void ModificaEta()
        {
           Console.WriteLine("inserisci la nuova Eta");
            string streta = Console.ReadLine();
            int eta = Convert.ToInt32(streta);
            _eta = eta;
        }

        public string StampaAnagrafica()
        {
            return $"Dati anagrafici: \n \tCognome:{_cognome} \n \tNome:{_nome} \n \tEta:{_eta}";
        }


        //PER CONFRONTI
        public static bool operator > (Persona p,Persona p2)
        {
            if(p.Eta > p2.Eta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Persona p, Persona p2)
        {
            if (p.Eta > p2.Eta)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator == (Persona p, Persona p2)
        {
            if (p.Eta == p2.Eta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Persona p, Persona p2)
        {
            if (p.Eta != p2.Eta)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
