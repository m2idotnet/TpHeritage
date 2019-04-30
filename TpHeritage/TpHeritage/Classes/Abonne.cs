using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage.Classes
{
    public class Abonne
    {
        private string nom;
        private string prenom;
        protected int empruntsMax = 1;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Abonne()
        {
        }

        public Abonne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public bool Emprunter(Media media)
        {
            bool retour = false;
            if(empruntsMax > 0)
            {
                retour = media.Dispo;
                media.Dispo = false;
                empruntsMax--;   
            }
            return retour;
        }

        public void Rendre(Media m)
        {
            m.Dispo = true;
            empruntsMax++;
        }
    }
}
