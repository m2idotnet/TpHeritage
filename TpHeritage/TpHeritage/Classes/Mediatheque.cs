using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage.Classes
{
    public class Mediatheque
    {
        private List<Media> medias;

        public List<Media> Medias { get => medias; set => medias = value; }

        public Mediatheque()
        {
            Medias = new List<Media>();
        }

        public void AjouterMedia(Media m)
        {
            Medias.Add(m);
        }
    }
}
