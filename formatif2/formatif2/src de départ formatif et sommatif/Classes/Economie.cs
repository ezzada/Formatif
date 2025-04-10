using Examen2.ClassesUtilitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Classes
{
    internal class Economie
    {
        public string Nom {  get; set; }
        bool _genre;
        static public List<Entreprise> Entreprises = new List<Entreprise>();
        static public List<Transaction> Transactions = new List<Transaction>();


        //-------------------------------------------------
        //
        //-------------------------------------------------
        public Economie(string n="inconnu", bool g=true) { 
            Nom = n;
            _genre = g;  
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public int ChargerEntreprises()
        {
            Entreprises = new List<Entreprise>();
            if (File.Exists(U.FICHIER_ENTREPRISES))
            {
                StreamReader reader = File.OpenText(U.FICHIER_ENTREPRISES);
                string? ligneCourante;

                while (reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();

                    if (Parseur.ParsingEntreprise(ligneCourante, out Entreprise entrep))
                    {
                       Entreprises.Add(entrep);
                    }
                }
                reader.Close();
            }
            U.WL($"{Entreprises.Count} entreprises chargées");
            return 0;
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public int ChargerTransactions()
        {
            Transactions = new List<Transaction>();
            if (File.Exists(U.FICHIER_TRANSACTIONS))
            {
                StreamReader reader = File.OpenText(U.FICHIER_TRANSACTIONS);
                string? ligneCourante;

                while (reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();

                    if (Parseur.ParsingTransaction(ligneCourante, out Transaction trx))
                    {
                        Transactions.Add(trx);
                    }
                }
                reader.Close();
            }
            U.WL($"{Transactions.Count} Transaction chargées");
            return 0;
        }


        //-------------------------------------------------
        //
        //-------------------------------------------------
        public void AfficherEntreprises()
        {
            StringBuilder sb = new ("Économie ");
            if (_genre)
            {
                sb.Append(" de la ");
            }
            else
            {
                sb.Append(" du ");
            }
            sb.Append(Nom);
            sb.Append($", {Entreprises.Count} entreprises:");
            U.Titre(sb.ToString());


            
            U.WL($"{"Id",-7}{"Nom",-30}{"Fondée en",-8}");
            U.Sep(44);


            foreach(Entreprise entreprise in Entreprises)
            {
                entreprise.Afficher();
            }
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public void AfficherDepensePourUneEntrep()
        {
            U.W("ID de l'entreprise? : ");
            string input = U.RL();

            if (int.TryParse(input, out int idEntrep))
            {
                foreach (Entreprise entrep in Entreprises)
                {
                    if (idEntrep == entrep.Id)
                    {
                        entrep.AfficherDepense();
                        return;
                    }
                }
            }
            
            U.WL($"Aucune entreprise avec l'id {input}");
        }
        public void AfficherTransactionPourUneEntrep()
        {
            U.W("ID de l'entreprise? : ");
            string input = U.RL();

            if (int.TryParse(input, out int idEntrep))
            {
                foreach (Entreprise entrep in Entreprises)
                {
                    if (idEntrep == entrep.Id)
                    {
                        entrep.AfficherTransactions();
                        return;
                    }
                }
            }

            U.WL($"Aucune entreprise avec l'id {input}");
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public void RepartitionTransactions()
        {
            foreach (Entreprise entrep in Entreprises)
            {
                foreach (Transaction trx in Transactions)
                {
                    if (trx.getIdEntreprise() == entrep.Id)
                    {
                        
                        entrep.CompteBancaire.Add(trx);
                        
                    }
                }
            }
        }
    }
}
