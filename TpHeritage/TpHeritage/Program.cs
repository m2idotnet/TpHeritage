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
            Console.WriteLine("-----Test abonné emprunt------");
            Abonne a = new Abonne("toto", "tata");
            Console.WriteLine(a.Emprunter(l1));
            Console.WriteLine(a.Emprunter(l2));
            a.Rendre(l1);
            Console.WriteLine(a.Emprunter(l2));
            a.Rendre(l2);
            Console.WriteLine("-----Test Etudiant abonné emprunt------");
            EtudiantAbonne e = new EtudiantAbonne("titi", "minet");
            Console.WriteLine(e.Emprunter(l1));
            Console.WriteLine(e.Emprunter(l2));
            Console.WriteLine(e.Emprunter(d1));
            e.Rendre(l2);
            Console.WriteLine(e.Emprunter(d1));
            Console.ReadLine();
        }
    }
}
