namespace EsempioGitHub4C
{
    partial class frmLancio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPremi = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPremi
            // 
            this.btnPremi.Location = new System.Drawing.Point(143, 104);
            this.btnPremi.Name = "btnPremi";
            this.btnPremi.Size = new System.Drawing.Size(75, 23);
            this.btnPremi.TabIndex = 0;
            this.btnPremi.Text = "Premi";
            this.btnPremi.UseVisualStyleBackColor = true;
            this.btnPremi.Click += new System.EventHandler(this.btnPremi_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(265, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // frmLancio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPremi);
            this.Name = "frmLancio";
            this.Text = "Saluti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPremi;
        private System.Windows.Forms.TextBox txtNome;
    }
}

