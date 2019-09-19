using System;
using System.Collections.Generic;
using System.Text;

namespace BilbioFilm
{
    public class Film
    {
        public int NbEntrees { get; set; }
        public string PhotoFilm { get; set; }

        public string TitreFilm { get; set; }

        public List<Acteur>LesActeurs;
        public List<Realisateur> LeRéalisateur;
        public void AjouterActeur(Acteur unActeur)
        {

            LesActeurs.Add(unActeur);
        }

    }
}
