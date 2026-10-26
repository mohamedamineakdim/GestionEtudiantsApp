using System;
using System.Windows.Forms;
using GestionEtudiantsApp.BLL.Managers;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp
{
    public partial class FrmEtudiants : Form
    {
        private EtudiantManager manager;
        public FrmEtudiants()
        {
            InitializeComponent();
        }

        private void FrmEtudiants_Load(object sender, EventArgs e)
        {
            manager = new EtudiantManager();
            ChargerEtudiants();
        }
        private void ChargerEtudiants()
        {
            dgvEtudiants.DataSource = null;
            dgvEtudiants.DataSource = manager.GetTousLesEtudiants();


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Etudiant e1 = new Etudiant
            {
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Groupe = txtGroupe.Text,
                DateNaissance = dtpDateNaissance.Value
            };

            manager.AjouterEtudiant(e1);
            ChargerEtudiants();
            ViderChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvEtudiants.CurrentRow == null) return;

            Etudiant e1 = (Etudiant)dgvEtudiants.CurrentRow.DataBoundItem;

            e1.Nom = txtNom.Text;
            e1.Prenom = txtPrenom.Text;
            e1.Groupe = txtGroupe.Text;
            e1.DateNaissance = dtpDateNaissance.Value;

            manager.ModifierEtudiant(e1);
            ChargerEtudiants();
            ViderChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvEtudiants.CurrentRow == null) return;

            Etudiant e1 = (Etudiant)dgvEtudiants.CurrentRow.DataBoundItem;

            DialogResult r = MessageBox.Show(
                "Voulez-vous vraiment supprimer cet étudiant ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                manager.SupprimerEtudiant(e1.IdEtudiant);
                ChargerEtudiants();
                ViderChamps();
            }
        }

        private void dgvEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEtudiants.CurrentRow == null) return;

            Etudiant e1 = (Etudiant)dgvEtudiants.CurrentRow.DataBoundItem;

            txtNom.Text = e1.Nom;
            txtPrenom.Text = e1.Prenom;
            txtGroupe.Text = e1.Groupe;
            dtpDateNaissance.Value = e1.DateNaissance;
        }

        // ===================== UTILS =====================
        private void ViderChamps()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtGroupe.Clear();
            dtpDateNaissance.Value = DateTime.Now;
        }
    }
}

