namespace _02_Lehrer_Schueler_Registrierung
{
    partial class frm_Main
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
            this.gb_Person = new System.Windows.Forms.GroupBox();
            this.cb_Schulpartner = new System.Windows.Forms.ComboBox();
            this.tb_Jahrgang = new System.Windows.Forms.TextBox();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.lb_Schulpartner = new System.Windows.Forms.Label();
            this.lb_Nachname = new System.Windows.Forms.Label();
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.lb_Jahrgang = new System.Windows.Forms.Label();
            this.gb_Anschrift = new System.Windows.Forms.GroupBox();
            this.tb_Hausnummer = new System.Windows.Forms.TextBox();
            this.tb_Wohnort = new System.Windows.Forms.TextBox();
            this.tb_Strasse = new System.Windows.Forms.TextBox();
            this.lb_Hausnummer = new System.Windows.Forms.Label();
            this.lb_Wohnort = new System.Windows.Forms.Label();
            this.lb_Strasse = new System.Windows.Forms.Label();
            this.btn_DatensatzSpeichern = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_DatensaetzeAnzeigen = new System.Windows.Forms.Button();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.gb_Person.SuspendLayout();
            this.gb_Anschrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Person
            // 
            this.gb_Person.Controls.Add(this.cb_Schulpartner);
            this.gb_Person.Controls.Add(this.tb_Jahrgang);
            this.gb_Person.Controls.Add(this.tb_Nachname);
            this.gb_Person.Controls.Add(this.tb_Vorname);
            this.gb_Person.Controls.Add(this.lb_Schulpartner);
            this.gb_Person.Controls.Add(this.lb_Nachname);
            this.gb_Person.Controls.Add(this.lb_Vorname);
            this.gb_Person.Controls.Add(this.lb_Jahrgang);
            this.gb_Person.Location = new System.Drawing.Point(27, 39);
            this.gb_Person.Name = "gb_Person";
            this.gb_Person.Size = new System.Drawing.Size(349, 206);
            this.gb_Person.TabIndex = 0;
            this.gb_Person.TabStop = false;
            this.gb_Person.Text = "Person:";
            // 
            // cb_Schulpartner
            // 
            this.cb_Schulpartner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cb_Schulpartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Schulpartner.FormattingEnabled = true;
            this.cb_Schulpartner.Items.AddRange(new object[] {
            "Lehrer",
            "Schüler"});
            this.cb_Schulpartner.Location = new System.Drawing.Point(127, 33);
            this.cb_Schulpartner.Name = "cb_Schulpartner";
            this.cb_Schulpartner.Size = new System.Drawing.Size(192, 24);
            this.cb_Schulpartner.TabIndex = 0;
            // 
            // tb_Jahrgang
            // 
            this.tb_Jahrgang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Jahrgang.Location = new System.Drawing.Point(127, 159);
            this.tb_Jahrgang.Name = "tb_Jahrgang";
            this.tb_Jahrgang.Size = new System.Drawing.Size(192, 22);
            this.tb_Jahrgang.TabIndex = 12;
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nachname.Location = new System.Drawing.Point(127, 121);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(192, 22);
            this.tb_Nachname.TabIndex = 11;
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Vorname.Location = new System.Drawing.Point(127, 83);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(192, 22);
            this.tb_Vorname.TabIndex = 10;
            // 
            // lb_Schulpartner
            // 
            this.lb_Schulpartner.AutoSize = true;
            this.lb_Schulpartner.Location = new System.Drawing.Point(24, 36);
            this.lb_Schulpartner.Name = "lb_Schulpartner";
            this.lb_Schulpartner.Size = new System.Drawing.Size(85, 16);
            this.lb_Schulpartner.TabIndex = 2;
            this.lb_Schulpartner.Text = "Schulpartner:";
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.AutoSize = true;
            this.lb_Nachname.Location = new System.Drawing.Point(33, 124);
            this.lb_Nachname.Name = "lb_Nachname";
            this.lb_Nachname.Size = new System.Drawing.Size(76, 16);
            this.lb_Nachname.TabIndex = 4;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Location = new System.Drawing.Point(44, 86);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(65, 16);
            this.lb_Vorname.TabIndex = 3;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // lb_Jahrgang
            // 
            this.lb_Jahrgang.AutoSize = true;
            this.lb_Jahrgang.Location = new System.Drawing.Point(42, 162);
            this.lb_Jahrgang.Name = "lb_Jahrgang";
            this.lb_Jahrgang.Size = new System.Drawing.Size(67, 16);
            this.lb_Jahrgang.TabIndex = 5;
            this.lb_Jahrgang.Text = "Jahrgang:";
            // 
            // gb_Anschrift
            // 
            this.gb_Anschrift.Controls.Add(this.tb_Hausnummer);
            this.gb_Anschrift.Controls.Add(this.tb_Wohnort);
            this.gb_Anschrift.Controls.Add(this.tb_Strasse);
            this.gb_Anschrift.Controls.Add(this.lb_Hausnummer);
            this.gb_Anschrift.Controls.Add(this.lb_Wohnort);
            this.gb_Anschrift.Controls.Add(this.lb_Strasse);
            this.gb_Anschrift.Location = new System.Drawing.Point(27, 271);
            this.gb_Anschrift.Name = "gb_Anschrift";
            this.gb_Anschrift.Size = new System.Drawing.Size(349, 143);
            this.gb_Anschrift.TabIndex = 1;
            this.gb_Anschrift.TabStop = false;
            this.gb_Anschrift.Text = "Anschrift";
            // 
            // tb_Hausnummer
            // 
            this.tb_Hausnummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Hausnummer.Location = new System.Drawing.Point(127, 100);
            this.tb_Hausnummer.Name = "tb_Hausnummer";
            this.tb_Hausnummer.Size = new System.Drawing.Size(192, 22);
            this.tb_Hausnummer.TabIndex = 13;
            // 
            // tb_Wohnort
            // 
            this.tb_Wohnort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Wohnort.Location = new System.Drawing.Point(127, 28);
            this.tb_Wohnort.Name = "tb_Wohnort";
            this.tb_Wohnort.Size = new System.Drawing.Size(192, 22);
            this.tb_Wohnort.TabIndex = 11;
            // 
            // tb_Strasse
            // 
            this.tb_Strasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Strasse.Location = new System.Drawing.Point(127, 64);
            this.tb_Strasse.Name = "tb_Strasse";
            this.tb_Strasse.Size = new System.Drawing.Size(192, 22);
            this.tb_Strasse.TabIndex = 12;
            // 
            // lb_Hausnummer
            // 
            this.lb_Hausnummer.AutoSize = true;
            this.lb_Hausnummer.Location = new System.Drawing.Point(19, 100);
            this.lb_Hausnummer.Name = "lb_Hausnummer";
            this.lb_Hausnummer.Size = new System.Drawing.Size(90, 16);
            this.lb_Hausnummer.TabIndex = 8;
            this.lb_Hausnummer.Text = "Hausnummer:";
            // 
            // lb_Wohnort
            // 
            this.lb_Wohnort.AutoSize = true;
            this.lb_Wohnort.Location = new System.Drawing.Point(49, 28);
            this.lb_Wohnort.Name = "lb_Wohnort";
            this.lb_Wohnort.Size = new System.Drawing.Size(60, 16);
            this.lb_Wohnort.TabIndex = 6;
            this.lb_Wohnort.Text = "Wohnort:";
            // 
            // lb_Strasse
            // 
            this.lb_Strasse.AutoSize = true;
            this.lb_Strasse.Location = new System.Drawing.Point(59, 64);
            this.lb_Strasse.Name = "lb_Strasse";
            this.lb_Strasse.Size = new System.Drawing.Size(50, 16);
            this.lb_Strasse.TabIndex = 7;
            this.lb_Strasse.Text = "Straße:";
            // 
            // btn_DatensatzSpeichern
            // 
            this.btn_DatensatzSpeichern.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DatensatzSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DatensatzSpeichern.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatensatzSpeichern.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DatensatzSpeichern.Location = new System.Drawing.Point(486, 39);
            this.btn_DatensatzSpeichern.Name = "btn_DatensatzSpeichern";
            this.btn_DatensatzSpeichern.Size = new System.Drawing.Size(248, 72);
            this.btn_DatensatzSpeichern.TabIndex = 2;
            this.btn_DatensatzSpeichern.Text = "Datensatz speichern";
            this.btn_DatensatzSpeichern.UseVisualStyleBackColor = false;
            this.btn_DatensatzSpeichern.Click += new System.EventHandler(this.btn_DatensatzSpeichern_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(486, 210);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(248, 67);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Werte löschen";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_DatensaetzeAnzeigen
            // 
            this.btn_DatensaetzeAnzeigen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DatensaetzeAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DatensaetzeAnzeigen.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatensaetzeAnzeigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DatensaetzeAnzeigen.Location = new System.Drawing.Point(486, 125);
            this.btn_DatensaetzeAnzeigen.Name = "btn_DatensaetzeAnzeigen";
            this.btn_DatensaetzeAnzeigen.Size = new System.Drawing.Size(248, 70);
            this.btn_DatensaetzeAnzeigen.TabIndex = 5;
            this.btn_DatensaetzeAnzeigen.Text = "Datensätze anzeigen";
            this.btn_DatensaetzeAnzeigen.UseVisualStyleBackColor = false;
            this.btn_DatensaetzeAnzeigen.Click += new System.EventHandler(this.btn_DatensaetzeAnzeigen_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Beenden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Beenden.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beenden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Beenden.Location = new System.Drawing.Point(486, 290);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(248, 67);
            this.btn_Beenden.TabIndex = 6;
            this.btn_Beenden.Text = "Beenden";
            this.btn_Beenden.UseVisualStyleBackColor = false;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 518);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.btn_DatensaetzeAnzeigen);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_DatensatzSpeichern);
            this.Controls.Add(this.gb_Anschrift);
            this.Controls.Add(this.gb_Person);
            this.Name = "frm_Main";
            this.Text = "Lehrer Schüler Registrierung";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.gb_Person.ResumeLayout(false);
            this.gb_Person.PerformLayout();
            this.gb_Anschrift.ResumeLayout(false);
            this.gb_Anschrift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Person;
        private System.Windows.Forms.GroupBox gb_Anschrift;
        private System.Windows.Forms.Label lb_Schulpartner;
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.Label lb_Jahrgang;
        private System.Windows.Forms.Label lb_Strasse;
        private System.Windows.Forms.Label lb_Nachname;
        private System.Windows.Forms.Label lb_Wohnort;
        private System.Windows.Forms.Label lb_Hausnummer;
        private System.Windows.Forms.TextBox tb_Jahrgang;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.TextBox tb_Hausnummer;
        private System.Windows.Forms.TextBox tb_Wohnort;
        private System.Windows.Forms.TextBox tb_Strasse;
        private System.Windows.Forms.ComboBox cb_Schulpartner;
        private System.Windows.Forms.Button btn_DatensatzSpeichern;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_DatensaetzeAnzeigen;
        private System.Windows.Forms.Button btn_Beenden;
    }
}

