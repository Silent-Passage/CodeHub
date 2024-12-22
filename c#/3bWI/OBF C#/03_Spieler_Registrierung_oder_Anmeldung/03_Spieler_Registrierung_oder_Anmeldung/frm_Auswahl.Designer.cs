namespace _03_Spieler_Registrierung_oder_Anmeldung
{
    partial class frm_Auswahl
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
            this.btn_Registrieren = new System.Windows.Forms.Button();
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Registrieren
            // 
            this.btn_Registrieren.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Registrieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrieren.Location = new System.Drawing.Point(381, 12);
            this.btn_Registrieren.Name = "btn_Registrieren";
            this.btn_Registrieren.Size = new System.Drawing.Size(347, 98);
            this.btn_Registrieren.TabIndex = 1;
            this.btn_Registrieren.Text = "Spieler registrieren";
            this.btn_Registrieren.UseVisualStyleBackColor = false;
            this.btn_Registrieren.Click += new System.EventHandler(this.btn_Registrieren_Click);
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Anmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anmelden.Location = new System.Drawing.Point(12, 12);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(347, 98);
            this.btn_Anmelden.TabIndex = 2;
            this.btn_Anmelden.Text = "Spieler anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = false;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // Frm_Auswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 122);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.btn_Registrieren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Auswahl";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Registrieren;
        private System.Windows.Forms.Button btn_Anmelden;
    }
}

