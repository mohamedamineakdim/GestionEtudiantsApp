namespace GestionEtudiantsApp.UII
{
    partial class FrmMatieres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void     Dispose(bool disposing)
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
            this.dgvMatieres = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblo = new System.Windows.Forms.Label();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.txto = new System.Windows.Forms.Label();
            this.txtNomMatiere = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatieres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatieres
            // 
            this.dgvMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatieres.Location = new System.Drawing.Point(58, 41);
            this.dgvMatieres.Name = "dgvMatieres";
            this.dgvMatieres.RowHeadersWidth = 51;
            this.dgvMatieres.RowTemplate.Height = 24;
            this.dgvMatieres.Size = new System.Drawing.Size(698, 215);
            this.dgvMatieres.TabIndex = 31;
            this.dgvMatieres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatieres_CellContentClick);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(561, 404);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(127, 28);
            this.btnSupprimer.TabIndex = 30;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(319, 404);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 28);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(88, 404);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 28);
            this.btnAjouter.TabIndex = 28;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblo
            // 
            this.lblo.AutoSize = true;
            this.lblo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblo.Location = new System.Drawing.Point(87, 323);
            this.lblo.Name = "lblo";
            this.lblo.Size = new System.Drawing.Size(109, 20);
            this.lblo.TabIndex = 27;
            this.lblo.Text = "Coefficient : ";
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoefficient.ForeColor = System.Drawing.Color.Red;
            this.txtCoefficient.Location = new System.Drawing.Point(260, 320);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.Size = new System.Drawing.Size(100, 28);
            this.txtCoefficient.TabIndex = 26;
            // 
            // txto
            // 
            this.txto.AutoSize = true;
            this.txto.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txto.Location = new System.Drawing.Point(87, 286);
            this.txto.Name = "txto";
            this.txto.Size = new System.Drawing.Size(120, 20);
            this.txto.TabIndex = 25;
            this.txto.Text = "Nom matière :";
            // 
            // txtNomMatiere
            // 
            this.txtNomMatiere.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMatiere.ForeColor = System.Drawing.Color.Red;
            this.txtNomMatiere.Location = new System.Drawing.Point(260, 283);
            this.txtNomMatiere.Name = "txtNomMatiere";
            this.txtNomMatiere.Size = new System.Drawing.Size(100, 28);
            this.txtNomMatiere.TabIndex = 24;
            // 
            // FrmMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(817, 498);
            this.Controls.Add(this.dgvMatieres);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblo);
            this.Controls.Add(this.txtCoefficient);
            this.Controls.Add(this.txto);
            this.Controls.Add(this.txtNomMatiere);
            this.Name = "FrmMatieres";
            this.Text = "FrmMatieres";
            this.Load += new System.EventHandler(this.FrmMatieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatieres;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblo;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.Label txto;
        private System.Windows.Forms.TextBox txtNomMatiere;
    }
}