using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;//Namensraum für das Formatieren der Daten in Binärcode


namespace _02_Lehrer_Schueler_Registrierung
{
    public partial class frm_Ausgabe : Form
    {
        //Objekt vom Datentyp frm_Registrierung
        //Wird benötigt, um das Formular frm_Registrierung ansprechen zu können
        frm_Main My_frmMain = new frm_Main();
        //Konstruktor der Form frm_Main
        //Modiziert mit einem Übergabeparameter vom Datentyp frm_Main
        public frm_Ausgabe(frm_Main frmMain)
        {
            //Die Daten des Formulars frm_Main werden für das gesamte Formular frm_Ausgabe
            //sichtbar gemacht
            My_frmMain = frmMain;
            InitializeComponent();
        }

        private void btn_Schliessen_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void frm_Ausgabe_Load(object sender, EventArgs e)
        {
            List<CPerson> My_CPersonenlist = new List<CPerson>();
            //CPerson My_CPerson = new CPerson();
            try
            {
                FileStream My_FileStream = new FileStream("Lehrer_Schueler.txt", FileMode.Open);
                BinaryFormatter My_BinaryFormatter = new BinaryFormatter();
                //Datentypumwandlung
                My_CPersonenlist = (List<CPerson>)My_BinaryFormatter.Deserialize(My_FileStream);
                //Füllen dess Datagrids
                dataGrid_CPersonen.DataSource = My_CPersonenlist;
                dataGrid_CPersonen.Columns[0].HeaderText = "Schulpartner";
                dataGrid_CPersonen.Columns[1].HeaderText = "Vorname";
                dataGrid_CPersonen.Columns[2].HeaderText = "Nachname";
                dataGrid_CPersonen.Columns[3].HeaderText = "Jahrgang";
                dataGrid_CPersonen.Columns[4].HeaderText = "Wohnort";
                dataGrid_CPersonen.Columns[5].HeaderText = "Straße";
                dataGrid_CPersonen.Columns[6].HeaderText = "Hausnummer";
                My_FileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lehrer Schüler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Ausgabe_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Visible der Form frm_Registrierung muss hier auf true gesetzt werden
            //Daher brauchen einen Zugriff auf das Formular frm_Main
            My_frmMain.Visible = true;
        }
    }
}
