using Examen2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.ClassesUtilitaires
{
    internal class Parseur
    {

        //-------------------------------------------------
        //
        //-------------------------------------------------
        public static bool ParsingEntreprise(string? infoBrute, out Entreprise entrep)
        {
            entrep = new Entreprise();

            if (infoBrute == null)
                return false;

            int nbChamps = compteurChamps(infoBrute);

            if (nbChamps == 3)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                entrep = new Entreprise(int.Parse(tabInfoBrute[0]), tabInfoBrute[1], int.Parse(tabInfoBrute[2]));
                return true;
            }
            return false;
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        public static bool ParsingTransaction(string? infoBrute, out Transaction trx)
        {
            trx = new Transaction();

            if (infoBrute == null)
                return false;

            int nbChamps = compteurChamps(infoBrute);

            if (nbChamps == 4)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                trx = new Transaction(int.Parse(tabInfoBrute[0]), int.Parse(tabInfoBrute[1]), double.Parse(tabInfoBrute[2]), tabInfoBrute[3]);
                return true;
            }
            return false;
        }
        //----------------------------------
        //
        //----------------------------------
        static int compteurChamps(string infoBrute)
        {
            int nbChamps = 0;
            if (infoBrute.Length == 0)
            {
                return 0;
            }

            nbChamps++;
            foreach (char ch in infoBrute)
            {
                if (ch == ';')
                    nbChamps++;
            }
            return nbChamps;
        }
    }
}
