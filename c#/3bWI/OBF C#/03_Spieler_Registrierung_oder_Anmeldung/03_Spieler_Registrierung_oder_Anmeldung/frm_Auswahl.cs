using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Spieler_Registrierung_oder_Anmeldung
{
    public partial class frm_Auswahl : Form
    {
        public frm_Auswahl()
        {
            InitializeComponent();
        }
        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            frm_Anmeldung My_frmAnmeldung = new frm_Anmeldung("Anmelden", this);
            this.Visible = false;
            My_frmAnmeldung.Show();

            //Button My_Button = new Button();
            //My_Button = (Button)sender;
            //frm_Anmeldung My_frmAnmeldung = new frm_Anmeldung(this, My_Button.Text);
            //My_frmAnmeldung.Show();
        }
        private void btn_Registrieren_Click(object sender, EventArgs e)
        {
            frm_Anmeldung My_frmRegistrierung = new frm_Anmeldung("Registrieren", this);
            this.Visible = false;
            My_frmRegistrierung.Show();
        }

    }
    
}
