namespace GestionEtudiantsApps
{
    partial class FrmNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cboEtudiants = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboMatieres = new System.Windows.Forms.ComboBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Étudiant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(410, 262);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 28);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(410, 310);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(127, 28);
            this.btnSupprimer.TabIndex = 33;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cboEtudiants
            // 
            this.cboEtudiants.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEtudiants.FormattingEnabled = true;
            this.cboEtudiants.Location = new System.Drawing.Point(147, 306);
            this.cboEtudiants.Name = "cboEtudiants";
            this.cboEtudiants.Size = new System.Drawing.Size(121, 28);
            this.cboEtudiants.TabIndex = 34;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.Red;
            this.txtNote.Location = new System.Drawing.Point(147, 258);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 28);
            this.txtNote.TabIndex = 35;
            // 
            // cboMatieres
            // 
            this.cboMatieres.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatieres.FormattingEnabled = true;
            this.cboMatieres.Location = new System.Drawing.Point(147, 358);
            this.cboMatieres.Name = "cboMatieres";
            this.cboMatieres.Size = new System.Drawing.Size(121, 28);
            this.cboMatieres.TabIndex = 36;
            // 
            // dgvNotes
            // 
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(77, 12);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersWidth = 51;
            this.dgvNotes.RowTemplate.Height = 24;
            this.dgvNotes.Size = new System.Drawing.Size(628, 189);
            this.dgvNotes.TabIndex = 37;
            this.dgvNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Note : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Matière : ";
            // 
            // Étudiant
            // 
            this.Étudiant.AutoSize = true;
            this.Étudiant.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Étudiant.Location = new System.Drawing.Point(26, 314);
            this.Étudiant.Name = "Étudiant";
            this.Étudiant.Size = new System.Drawing.Size(87, 20);
            this.Étudiant.TabIndex = 38;
            this.Étudiant.Text = "Étudiant :";
            // 
            // FrmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Étudiant);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.cboMatieres);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboEtudiants);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FrmNotes";
            this.Text = "FrmNotes";
            this.Load += new System.EventHandler(this.FrmNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cboEtudiants;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboMatieres;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Étudiant;
    }
}