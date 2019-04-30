using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage.Classes
{
    public class Livre : Media
    {
        private string auteur;
        private int nombrePage;

        public string Auteur { get => auteur; set => auteur = value; }
        public int NombrePage { get => nombrePage; set => nombrePage = value; }

        public Livre()
        {

        }
        public Livre(string t) : base(t)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " Auteur : " + Auteur + " Nombre de pages : " + NombrePage;
        }
    }
}
