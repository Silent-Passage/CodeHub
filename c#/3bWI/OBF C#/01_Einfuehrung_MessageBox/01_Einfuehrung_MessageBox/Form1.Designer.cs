namespace _01_Einfuehrung_MessageBox
{
    partial class frm_Main
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
            this.btn_Information = new System.Windows.Forms.Button();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Information
            // 
            this.btn_Information.BackColor = System.Drawing.Color.Red;
            this.btn_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Information.Location = new System.Drawing.Point(378, 61);
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.Size = new System.Drawing.Size(390, 157);
            this.btn_Information.TabIndex = 0;
            this.btn_Information.Text = "Information anzeigen";
            this.btn_Information.UseVisualStyleBackColor = false;
            this.btn_Information.Click += new System.EventHandler(this.btn_Information_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beenden.Location = new System.Drawing.Point(378, 251);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(390, 145);
            this.btn_Beenden.TabIndex = 1;
            this.btn_Beenden.Text = "Programm beenden ja/nein";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.btn_Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Einführung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Information;
        private System.Windows.Forms.Button btn_Beenden;
    }
}

