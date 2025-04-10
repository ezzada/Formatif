using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    internal class U
    {
        public const string DOSSIER_RACINE = @"d:\examen2\BaseDeDonnees\";
        public const string FICHIER_ENTREPRISES = DOSSIER_RACINE + "entreprises.txt";
        public const string FICHIER_TRANSACTIONS= DOSSIER_RACINE + "transactions.txt";

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public void Titre(string t)
        {
            foreach (char c in t)
            {
                W("-");
            }
            WL();
            WL(t);
            foreach (char c in t)
            {
                W("_");
            }
            WL();
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public void WL(string t = "")
        {
            Console.WriteLine(t);
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public void W(string t)
        {
            Console.Write(t);
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public string? RL()
        {

            return Console.ReadLine();
        }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public char RC()
        {
            return Console.ReadKey().KeyChar;
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public void P()
        {
            WL("\n\nAppuyez touche...");
            Console.ReadKey();
            
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public void CLR()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        static public void Sep(int nb = 25, string msg="")
        {
            for(int i=0; i<nb/2; i++)
            {
                W("_");
            }
            W(msg);
            for (int i = 0; i < nb / 2; i++)
            {
                W("_");
            }
            WL();
        }
    }
}
