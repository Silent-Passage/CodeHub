namespace _03_Spieler_Registrierung_oder_Anmeldung
{
    partial class frm_Anmeldung
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
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.lb_Nachname = new System.Windows.Forms.Label();
            this.lb_Passwort = new System.Windows.Forms.Label();
            this.lb_Passwort_bestaetigen = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.tb_Passwort = new System.Windows.Forms.TextBox();
            this.tb_Passwort_bestaetigen = new System.Windows.Forms.TextBox();
            this.btn_Aktion = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Location = new System.Drawing.Point(114, 59);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(65, 16);
            this.lb_Vorname.TabIndex = 0;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.AutoSize = true;
            this.lb_Nachname.Location = new System.Drawing.Point(103, 110);
            this.lb_Nachname.Name = "lb_Nachname";
            this.lb_Nachname.Size = new System.Drawing.Size(76, 16);
            this.lb_Nachname.TabIndex = 1;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // lb_Passwort
            // 
            this.lb_Passwort.AutoSize = true;
            this.lb_Passwort.Location = new System.Drawing.Point(114, 165);
            this.lb_Passwort.Name = "lb_Passwort";
            this.lb_Passwort.Size = new System.Drawing.Size(65, 16);
            this.lb_Passwort.TabIndex = 2;
            this.lb_Passwort.Text = "Passwort:";
            // 
            // lb_Passwort_bestaetigen
            // 
            this.lb_Passwort_bestaetigen.AutoSize = true;
            this.lb_Passwort_bestaetigen.Location = new System.Drawing.Point(48, 221);
            this.lb_Passwort_bestaetigen.Name = "lb_Passwort_bestaetigen";
            this.lb_Passwort_bestaetigen.Size = new System.Drawing.Size(131, 16);
            this.lb_Passwort_bestaetigen.TabIndex = 3;
            this.lb_Passwort_bestaetigen.Text = "Passwort bestätigen:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(241, 56);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(365, 22);
            this.tb_Vorname.TabIndex = 4;
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Location = new System.Drawing.Point(241, 107);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(365, 22);
            this.tb_Nachname.TabIndex = 5;
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Location = new System.Drawing.Point(241, 162);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.PasswordChar = '*';
            this.tb_Passwort.Size = new System.Drawing.Size(365, 22);
            this.tb_Passwort.TabIndex = 6;
            // 
            // tb_Passwort_bestaetigen
            // 
            this.tb_Passwort_bestaetigen.Location = new System.Drawing.Point(241, 218);
            this.tb_Passwort_bestaetigen.Name = "tb_Passwort_bestaetigen";
            this.tb_Passwort_bestaetigen.PasswordChar = '*';
            this.tb_Passwort_bestaetigen.Size = new System.Drawing.Size(365, 22);
            this.tb_Passwort_bestaetigen.TabIndex = 7;
            // 
            // btn_Aktion
            // 
            this.btn_Aktion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Aktion.Location = new System.Drawing.Point(241, 290);
            this.btn_Aktion.Name = "btn_Aktion";
            this.btn_Aktion.Size = new System.Drawing.Size(175, 99);
            this.btn_Aktion.TabIndex = 8;
            this.btn_Aktion.UseVisualStyleBackColor = false;
            this.btn_Aktion.Click += new System.EventHandler(this.btn_Aktion_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Abbrechen.Location = new System.Drawing.Point(422, 290);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(184, 99);
            this.btn_Abbrechen.TabIndex = 9;
            this.btn_Abbrechen.Text = "abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = false;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // frm_Anmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Aktion);
            this.Controls.Add(this.tb_Passwort_bestaetigen);
            this.Controls.Add(this.tb_Passwort);
            this.Controls.Add(this.tb_Nachname);
            this.Controls.Add(this.tb_Vorname);
            this.Controls.Add(this.lb_Passwort_bestaetigen);
            this.Controls.Add(this.lb_Passwort);
            this.Controls.Add(this.lb_Nachname);
            this.Controls.Add(this.lb_Vorname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Anmeldung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Anmeldung_FormClosed);
            this.Load += new System.EventHandler(this.frm_Anmeldung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.Label lb_Nachname;
        private System.Windows.Forms.Label lb_Passwort;
        private System.Windows.Forms.Label lb_Passwort_bestaetigen;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.TextBox tb_Passwort;
        private System.Windows.Forms.TextBox tb_Passwort_bestaetigen;
        private System.Windows.Forms.Button btn_Aktion;
        private System.Windows.Forms.Button btn_Abbrechen;
    }
}