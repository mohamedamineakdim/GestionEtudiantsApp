using System.Collections.Generic;
using GestionEtudiantsApp.DAL;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp.BLL.Managers
{
    public class MatiereManager
    {
        private MatiereDAL dal = new MatiereDAL();

        public void AjouterMatiere(Matiere m)
        {
            dal.Ajouter(m);
        }

        public void ModifierMatiere(Matiere m)
        {
            dal.Modifier(m);
        }

        public void SupprimerMatiere(int id)
        {
            dal.Supprimer(id);
        }

        public List<Matiere> GetToutesLesMatieres()
        {
            return dal.Lister();
        }
    }
}
