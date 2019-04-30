using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage.Classes
{
    public class Media
    {
        private string titre;
        private int numero;
        private static int compteur = 0;

        //Propriété en lecture seul sans set
        public string Titre { get => titre; }
        public int Numero { get => numero; }

        public Media(string t)
        {
            //attribut car propriété en lecture seul
            titre = t;
            numero = compteur;
            compteur++;
        }

        //methode utilisée quand un objet de type media est utilisé comme une chaine de caractères
        public override string ToString()
        {
            return "Numéro : "+ Numero + " titre : " + Titre;
        }

        public bool plusPetit(Media doc)
        {
            return (Numero < doc.Numero);
        }
    }
}
