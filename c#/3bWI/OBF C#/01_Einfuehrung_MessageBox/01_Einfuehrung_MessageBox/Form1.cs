using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Einfuehrung_MessageBox
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo, ich bin da!", "Einführung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btn_Information.Location = new Point(25, 100); //Koordinatenursprung = links oben; nach rechts x+, nach unten y+
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            DialogResult My_DialogResult = DialogResult.OK;
            My_DialogResult = MessageBox.Show("Wollen Sie das Programm beenden?", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(My_DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Und Tschüss!", "Hau doch ab!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                //Alternativ
                //this.Close();
            }
            else
            {
                MessageBox.Show("Weiter weiter gehts!", "Hurra!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
