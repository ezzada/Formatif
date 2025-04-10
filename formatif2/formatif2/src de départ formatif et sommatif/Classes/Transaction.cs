using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Classes
{
    class Transaction
    {
        private int _id;
        private int _idEntreprise;
        public double Montant { get; set; }
        private string _horodateur;

        private static int _compteur;


        public string getHorodateur()
        {
            return _horodateur;
        }

        public int getIdEntreprise()
        {
            return _idEntreprise;
        }
        public Transaction()
        {
            _horodateur = "0001-01-01 00:00:00";
        }
        public Transaction(int id, int idEntrep, double m, string horo )
        {
            if (id == 0)
            {
                _compteur++;
                id = _compteur;
            }
            _id = id;
            Montant = m;
            _horodateur = horo;
            _idEntreprise = idEntrep;
        }

        public void Afficher()
        {
            Console.WriteLine("|{0, 6} | {1, 9} $ | {2, 20}|", _id, Montant, _horodateur);
        }

        public int getId()
        {
            return _id;
        }

        public static void SetCompteur(int idMax)
        {
            _compteur = idMax;
        }
    }
}
