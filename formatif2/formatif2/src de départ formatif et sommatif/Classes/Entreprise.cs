using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Examen2.ClassesUtilitaires;

namespace Examen2.Classes
{
    internal class Entreprise
    {
        public string Nom {  get; set; }   

        public int AnFondation {  get; set; } 
        
        public int Id { get; set; }

        public List<Transaction> CompteBancaire { get; set; }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public Entreprise()
        {
            Nom = "";
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        public Entreprise(int id = 0, string n = "inconnu", int af = 1)
        {
            Nom = n;   
            AnFondation = af;  
            Id = id;
            CompteBancaire = new List<Transaction>();
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        public void Afficher()
        {
            U.WL($"{Id,6} {Nom, -30} ({AnFondation, -4})");
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public void AfficherTransactions()
        {
            U.Titre($"Transactions de {Nom}");
            U.WL($"{"",-5}{"Id",-10}{"Montant",-16}{"Horodateur",-18}");
            U.Sep(45);
            foreach (Transaction trx in CompteBancaire)
            {
                if (trx.Montant >= 0)
                {
                    trx.Afficher();
                }
            }
        }
        public void AfficherDepense()
        {
            U.Titre($"Dépence de {Nom}");
            U.WL($"{"",-5}{"Id",-10}{"Montant",-16}{"Horodateur",-18}");
            U.Sep(45);
            foreach (Transaction trx in CompteBancaire)
            {
                if (trx.Montant < 0)
                {
                    trx.Afficher();
                }
            }
        }
       
    }
}
