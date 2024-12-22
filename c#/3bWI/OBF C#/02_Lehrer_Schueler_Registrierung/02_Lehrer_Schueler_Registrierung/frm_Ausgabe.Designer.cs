namespace _02_Lehrer_Schueler_Registrierung
{
    partial class frm_Ausgabe
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
            this.dataGrid_CPersonen = new System.Windows.Forms.DataGridView();
            this.btn_Schliessen_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_CPersonen
            // 
            this.dataGrid_CPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_CPersonen.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_CPersonen.Name = "dataGrid_CPersonen";
            this.dataGrid_CPersonen.RowHeadersWidth = 51;
            this.dataGrid_CPersonen.RowTemplate.Height = 24;
            this.dataGrid_CPersonen.Size = new System.Drawing.Size(1004, 453);
            this.dataGrid_CPersonen.TabIndex = 0;
            // 
            // btn_Schliessen_Click
            // 
            this.btn_Schliessen_Click.AutoEllipsis = true;
            this.btn_Schliessen_Click.Location = new System.Drawing.Point(393, 471);
            this.btn_Schliessen_Click.Name = "btn_Schliessen_Click";
            this.btn_Schliessen_Click.Size = new System.Drawing.Size(234, 48);
            this.btn_Schliessen_Click.TabIndex = 1;
            this.btn_Schliessen_Click.Text = "Ausgabe schließen";
            this.btn_Schliessen_Click.UseVisualStyleBackColor = true;
            this.btn_Schliessen_Click.Click += new System.EventHandler(this.btn_Schliessen_Click_Click);
            // 
            // frm_Ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 531);
            this.Controls.Add(this.btn_Schliessen_Click);
            this.Controls.Add(this.dataGrid_CPersonen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Ausgabe";
            this.Text = "frm_Ausgabe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Ausgabe_FormClosed);
            this.Load += new System.EventHandler(this.frm_Ausgabe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CPersonen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Schliessen_Click;
        private System.Windows.Forms.DataGridView dataGrid_CPersonen;
    }
}