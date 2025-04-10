using Examen2.Classes;
using Examen2.ClassesUtilitaires;


namespace Examen2
{
    internal class Program
    {
        public static Economie eco = new Economie("Québec", false);

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static void Main(string[] args)
        {
            eco.ChargerEntreprises();
            eco.ChargerTransactions();
            eco.RepartitionTransactions();
            
            Menu menu = new Menu("Transaction des entreprise Adam Ezzahiri");

            menu.Options.Add(new MenuItem("Afficher entreprises", 'A', eco.AfficherEntreprises));
            menu.Options.Add(new MenuItem("Afficher dépenses d'une entreprise", 'D', eco.AfficherDepensePourUneEntrep));
            menu.Options.Add(new MenuItem("Afficher Transaction d'une entreprise", 'T', eco.AfficherTransactionPourUneEntrep));



            menu.Afficher();
            menu.SaisirOption();
       }
    }
}
