using System;
using System.Collections.Generic;
using TpHeritage.Classes;

namespace TpHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Media l1 = new Livre("Harry Potter ") { Auteur = "J.K. Rowling", NombrePage = 240 };
            Media l2 = new Livre("GOT") { Auteur = "George R.R. Martin", NombrePage = 789 };
            Media d1 = new Dictionnaire("LARousse") { Tome = 10, Langue = "FR" };
            List<Media> liste = new List<Media>();
            liste.Add(l1);
            liste.Add(l2);
            liste.Add(d1);
            foreach(Media m in liste)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
