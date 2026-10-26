using System;

namespace GestionEtudiantsApp.Models
{
    public class Etudiant
    {
        public int IdEtudiant { get; set; }   // OBLIGATOIRE
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Groupe { get; set; }
    }
}
