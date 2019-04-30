using System;
using System.Collections.Generic;
using TpHeritage.Classes;

namespace TpHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediatheque mediatheque = new Mediatheque();
            Media l1 = new Livre("Harry Potter ") { Auteur = "J.K. Rowling", NombrePage = 240 };
            Media l2 = new Livre("GOT") { Auteur = "George R.R. Martin", NombrePage = 789 };
            Media d1 = new Dictionnaire("LARousse") { Tome = 10, Langue = "FR" };

            mediatheque.AjouterMedia(l1);
            mediatheque.AjouterMedia(l2);
            mediatheque.AjouterMedia(d1);
            foreach (Media m in mediatheque.Medias)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
