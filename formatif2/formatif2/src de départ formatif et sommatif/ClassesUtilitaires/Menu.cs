using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.ClassesUtilitaires
{
    internal class Menu
    {
        public string Nom { get; set; }
        public List<MenuItem> Options { get; set; }
        //-------------------------------------------------
        //
        //-------------------------------------------------
        public Menu(string n)
        {
            Nom = n;
            Options = new List<MenuItem>();
        }

         public void Afficher()
        //-------------------------------------------------
        //
        //-------------------------------------------------
        {
            U.CLR();
            U.Titre(Nom);
            U.WL();
            foreach (MenuItem option in Options) 
            {
                U.WL("\t" + option.Cle + ": " + option.Item);
            }

            U.WL("\n\nESC pour quitter");
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------
        public void SaisirOption()
        {
            ConsoleKeyInfo cle;
            while( (cle = Console.ReadKey(true)).Key != ConsoleKey.Escape ) 
            {
                foreach(MenuItem option in Options)
                {
                    if ((char)cle.Key == option.Cle)
                    {
                        U.CLR();
                        option.Fonc();
                        U.P();
                        Afficher();
                    }
                }
            }
        }
    }
}
