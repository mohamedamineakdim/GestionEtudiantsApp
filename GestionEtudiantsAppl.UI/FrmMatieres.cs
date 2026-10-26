using System;
using System.Windows.Forms;
using GestionEtudiantsApp.BLL.Managers;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApps
{
    public partial class FrmMatieres : Form
    {

        private MatiereManager manager;

        public FrmMatieres()
        {
            InitializeComponent();
        }

        private void FrmMatieres_Load(object sender, EventArgs e)
        {
            manager = new MatiereManager();
            ChargerMatieres();
        }
        private void ChargerMatieres()
        {
            dgvMatieres.AutoGenerateColumns = true;
            dgvMatieres.DataSource = null;
            dgvMatieres.DataSource = manager.GetToutesLesMatieres();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere m = new Matiere
            {
                NomMatiere = txtNomMatiere.Text,
                Coefficient = int.Parse(txtCoefficient.Text)
            };

            manager.AjouterMatiere(m);
            ChargerMatieres();
            ViderChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvMatieres.CurrentRow == null) return;

            Matiere m = (Matiere)dgvMatieres.CurrentRow.DataBoundItem;

            m.NomMatiere = txtNomMatiere.Text;
            m.Coefficient = int.Parse(txtCoefficient.Text);

            manager.ModifierMatiere(m);
            ChargerMatieres();
            ViderChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMatieres.CurrentRow == null) return;

            Matiere m = (Matiere)dgvMatieres.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Supprimer cette matière ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                manager.SupprimerMatiere(m.IdMatiere);
                ChargerMatieres();
                ViderChamps();
            }
        }

        private void dgvMatieres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMatieres.CurrentRow == null) return;

            Matiere m = (Matiere)dgvMatieres.CurrentRow.DataBoundItem;

            txtNomMatiere.Text = m.NomMatiere;
            txtCoefficient.Text = m.Coefficient.ToString();
        }
        private void ViderChamps()
        {
            txtNomMatiere.Clear();
            txtCoefficient.Clear();
        }
    }
}
