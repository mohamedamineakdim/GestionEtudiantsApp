using GestionEtudiantsApp.BLL.Managers;
using GestionEtudiantsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiantsApps
{
    public partial class FrmNotes : Form
    {
        private NoteManager noteManager;
        private EtudiantManager etudiantManager;
        private MatiereManager matiereManager;
        public FrmNotes()
        {
            InitializeComponent();
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            noteManager = new NoteManager();
            etudiantManager = new EtudiantManager();
            matiereManager = new MatiereManager();

            ChargerCombos();
            ChargerNotes();
        }
        private void ChargerCombos()
        {
            cboEtudiants.DataSource = etudiantManager.GetTousLesEtudiants();
            cboEtudiants.DisplayMember = "NomComplet";
            cboEtudiants.ValueMember = "IdEtudiant";

            cboMatieres.DataSource = matiereManager.GetToutesLesMatieres();
            cboMatieres.DisplayMember = "NomMatiere";
            cboMatieres.ValueMember = "IdMatiere";
        }
        private void ChargerNotes()
        {
            dgvNotes.AutoGenerateColumns = true;
            dgvNotes.DataSource = null;
            dgvNotes.DataSource = noteManager.GetToutesLesNotes();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Note n = new Note
            {
                IdEtudiant = (int)cboEtudiants.SelectedValue,
                IdMatiere = (int)cboMatieres.SelectedValue,
                Valeur = decimal.Parse(txtNote.Text)
            };

            noteManager.AjouterNote(n);
            ChargerNotes();
            txtNote.Clear();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvNotes.CurrentRow == null) return;

            Note n = (Note)dgvNotes.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Supprimer cette note ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                noteManager.SupprimerNote(n.IdNote);
                ChargerNotes();
            }
        }

        private void dgvNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotes.CurrentRow == null) return;

            Note n = (Note)dgvNotes.CurrentRow.DataBoundItem;
            txtNote.Text = n.Valeur.ToString();
        }
    }
}
