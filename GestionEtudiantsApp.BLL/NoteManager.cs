using System;
using System.Collections.Generic;
using GestionEtudiantsApp.DAL;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp.BLL.Managers
{
    public class NoteManager
    {
        private NoteDAL dal = new NoteDAL();

        public void AjouterNote(Note n)
        {
            // VALIDATION MÉTIER
            if (n.Valeur < 0 || n.Valeur > 20)
                throw new Exception("La note doit être entre 0 et 20.");

            dal.Ajouter(n);
        }

        public void SupprimerNote(int id)
        {
            dal.Supprimer(id);
        }

        public List<Note> GetToutesLesNotes()
        {
            return dal.Lister();
        }
    }
}
