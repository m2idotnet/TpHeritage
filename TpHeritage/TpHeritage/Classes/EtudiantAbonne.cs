using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage.Classes
{
    class EtudiantAbonne : Abonne
    {
        

        public EtudiantAbonne() 
        {
            empruntsMax = 2;
        }

        public EtudiantAbonne(string n, string p) :base(n,p)
        {
            empruntsMax = 2;
        }
    }
}
