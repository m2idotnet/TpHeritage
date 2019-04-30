using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage.Classes
{
    public class Dictionnaire : Media
    {
        private string langue;
        private int tome;

        public string Langue { get => langue; set => langue = value; }
        public int Tome { get => tome; set => tome = value; }

        public Dictionnaire()
        {

        }
        public Dictionnaire(string t) : base(t)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " Langue : "+ Langue + " Nombre de tome : "+ Tome;
        }
    }
}
