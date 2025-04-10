using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.ClassesUtilitaires
{
    internal class MenuItem
    {
        public string Item {  get; set; }   
        public char Cle { get; set; }   
        public Action Fonc { get; set; }


        //-------------------------------------------------
        //
        //-------------------------------------------------
        public MenuItem(string i, char c, Action aExecuter)
        {
            Item = i;
            Cle = c;
            Fonc = aExecuter;
        }
    }
}
