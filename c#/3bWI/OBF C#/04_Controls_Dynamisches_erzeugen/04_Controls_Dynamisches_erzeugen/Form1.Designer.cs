namespace _04_Controls_Dynamisches_erzeugen
{
    partial class frm_Container
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_erzeugen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_erzeugen
            // 
            this.btn_erzeugen.Location = new System.Drawing.Point(675, 414);
            this.btn_erzeugen.Name = "btn_erzeugen";
            this.btn_erzeugen.Size = new System.Drawing.Size(195, 77);
            this.btn_erzeugen.TabIndex = 0;
            this.btn_erzeugen.Text = "Trau dich!";
            this.btn_erzeugen.UseVisualStyleBackColor = true;
            this.btn_erzeugen.Click += new System.EventHandler(this.btn_erzeugen_Click);
            // 
            // frm_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 557);
            this.Controls.Add(this.btn_erzeugen);
            this.Name = "frm_Container";
            this.Text = "Dynamisches erzeugen von Controls";
            this.Load += new System.EventHandler(this.frm_Container_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_erzeugen;
    }
}

