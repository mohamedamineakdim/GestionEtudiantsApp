using System.Collections.Generic;
using System.Linq;
using GestionEtudiantsApp.DAL;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp.BLL.Managers
{
    public class EtudiantManager
    {
        private EtudiantDAL etudiantDAL;
        private NoteDAL noteDAL;

        public EtudiantManager()
        {
            etudiantDAL = new EtudiantDAL();
            noteDAL = new NoteDAL();
        }

        // CRUD
        public void AjouterEtudiant(Etudiant e)
        {
            etudiantDAL.Ajouter(e);
        }

        public void ModifierEtudiant(Etudiant e)
        {
            etudiantDAL.Modifier(e);
        }

        public void SupprimerEtudiant(int id)
        {
            etudiantDAL.Supprimer(id);
        }

        public List<Etudiant> GetTousLesEtudiants()
        {
            return etudiantDAL.Lister();
        }

      
        // CLASSEMENT GÉNÉRAL (LINQ)
        
        public List<ClassementDTO> ClassementGeneral()
        {
            var etudiants = etudiantDAL.Lister();
            var notes = noteDAL.Lister();

            var classement =
                from e in etudiants
                join n in notes on e.IdEtudiant equals n.IdEtudiant
                group n by new { e.IdEtudiant, e.Nom, e.Prenom } into g
                select new ClassementDTO
                {
                    IdEtudiant = g.Key.IdEtudiant,
                    Nom = g.Key.Nom,
                    Prenom = g.Key.Prenom,
                    Moyenne = g.Average(x => x.Valeur)
                };

            return classement
                .OrderByDescending(x => x.Moyenne)
                .ToList();
        }
    }
}
