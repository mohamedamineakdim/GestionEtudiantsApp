namespace GestionEtudiantsApp
{
    partial class FrmClassement
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
            this.dgvClassement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassement
            // 
            this.dgvClassement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassement.Location = new System.Drawing.Point(58, 12);
            this.dgvClassement.Name = "dgvClassement";
            this.dgvClassement.RowHeadersWidth = 51;
            this.dgvClassement.RowTemplate.Height = 24;
            this.dgvClassement.Size = new System.Drawing.Size(628, 189);
            this.dgvClassement.TabIndex = 12;
            // 
            // FrmClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClassement);
            this.Name = "FrmClassement";
            this.Text = "FrmClassement";
            this.Load += new System.EventHandler(this.FrmClassement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassement;
    }
}