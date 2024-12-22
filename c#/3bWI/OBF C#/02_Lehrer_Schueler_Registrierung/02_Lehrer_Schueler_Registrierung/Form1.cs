using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
//Neue Namensräume
using System.Xml.Serialization;//Für die SPeicherung im Xml-Format
using System.IO;//Namensraum für das Dateisystem
using System.Runtime.Serialization.Formatters.Binary;//Namensraum für das Formatieren der Daten in Binärcode
using System.Collections.Generic;

namespace _02_Lehrer_Schueler_Registrierung
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cb_Schulpartner.Text = "Lehrer";
            cb_Schulpartner.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_DatensatzSpeichern_Click(object sender, EventArgs e)
        {   
            if (tb_Vorname.Text == String.Empty)
            {
                MessageBox.Show("Bitte geben Sie den Vornamen der Person ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Vorname.Focus();
            }
            else if (tb_Nachname.Text == "")//"" ... Alternative zu string.Empty
            {
                MessageBox.Show("Bitte geben Sie den Nachnamen der Person ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Nachname.Focus();
            }
            else if (tb_Jahrgang.Text == "")  
            {
                MessageBox.Show("Bitte geben Sie den Jahrgang der Person ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Jahrgang.Focus();
            }
            else if (tb_Wohnort.Text == "")
            {
                MessageBox.Show("Bitte geben Sie den Wohnort der Person ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Wohnort.Focus();
            }
            else if (tb_Strasse.Text == "")
            {
                MessageBox.Show("Bitte geben Sie die Strasse der Person ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Strasse.Focus();
            }
            else if (tb_Hausnummer.Text == "")
            {
                MessageBox.Show("Bitte geben Sie die Hausnummer der Person ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Hausnummer.Focus();
            }
            else
            {
                //Speichern der Daten mit Hilfe List
                BinaryFormatter My_BinaryFormatter = new BinaryFormatter();
                Int16 iJahr = 0;
                try
                {
                    //Von der textBox wird ein String zurückgegeben => daher muss konvertiert werden
                    iJahr = Convert.ToInt16(tb_Jahrgang.Text);
                    //Erstellen des Objekts, welches anschließend gespeichert wird
                    List<CPerson> My_CPersonenlist = new List<CPerson>();//Liste entspricht einem Vektor in C++
                    //Für das Auslesen der Datei

                    //Liste die schon in der Datei vorhanden ist, auslesen
                    try
                    {                                               //Dateiname
                        FileStream My_FileStream = new FileStream("Lehrer_Schueler.txt", FileMode.OpenOrCreate);
                        //Beim ersten Mal muss die Datei erzeugt werden => Create
                        //Beim Erstellen der Datei ist der Filestream leer (die Datei beinhaltet noch keine Daten),
                        //daher kann nicht deserialisiert werden
                        //Man kann nicht etwas herauslesen was leer ist. => My_FileStream.Length = 0
                        //diese Fehlerquelle muss vermieden werden

                        if (My_FileStream.Length != 0)//Length: Eigenschaft daher keine Klammer
                        {
                            //Filestream nicht leer: Datei wird ausgelesen
                            My_CPersonenlist = (List<CPerson>)My_BinaryFormatter.Deserialize(My_FileStream);
                                            //Datentypumwandlung               //entspricht:auslesen
                        }
                        My_FileStream.Close();//Filestream wird geschlossen, da er anschließend mit einem anderen Modus geöffnet werden muss
                        //Die neue Person wird erstellt
                        CPerson My_Person = new CPerson(iJahr, cb_Schulpartner.Text, tb_Vorname.Text, tb_Nachname.Text, tb_Wohnort.Text, tb_Strasse.Text, tb_Hausnummer.Text);
                        //Nun wird an die vorhandene (ausgelesene Liste) das neue Element angehängt
                        My_CPersonenlist.Add(My_Person);//entspricht push_back(Wert)

                        FileStream My_FileStream1 = new FileStream("Lehrer_Schueler.txt", FileMode.Truncate);
                        //Truncate: Der bestehende Inhalt wird gelöscht

                        My_BinaryFormatter.Serialize(My_FileStream1, My_CPersonenlist);
                        //Alternativ: Xml - Serialisierung
                        //XmlSerializer My_XmlSerializer = new XmlSerializer(typeof(CPerson));
                        //FileStream My_Filestream1 = new FileStream("Lehrer_Schueler1.xml", FileMode.Append);
                        //My_XmlSerializer.Serialize(My_Filestream1, My_Person);
                        My_FileStream1.Close();

                        tb_Hausnummer.Clear();
                        tb_Jahrgang.Clear();
                        tb_Nachname.Clear();
                        tb_Strasse.Clear();
                        tb_Vorname.Clear();
                        tb_Wohnort.Clear();
                        cb_Schulpartner.Text = "Lehrer";
                        tb_Vorname.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lehrer Schüler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nGeben Sie bitte eine Jahreszahl ein!", "Lehrer Schüler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Jahrgang.Focus();
                    tb_Jahrgang.SelectAll();
                }   
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_Vorname.Clear();
            tb_Nachname.Clear();
            tb_Jahrgang.Clear();
            tb_Wohnort.Clear();
            tb_Strasse.Clear();
            tb_Hausnummer.Clear();
            tb_Strasse.Clear();
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_DatensaetzeAnzeigen_Click(object sender, EventArgs e)
        {
            //Altes Design
            //try
            //{
            //    List<CPerson> My_CPersonlist = new List<CPerson>();
            //    FileStream My_FileStream = new FileStream("Lehrer_Schueler.txt", FileMode.Open);
            //    BinaryFormatter My_BinaryFormatter = new BinaryFormatter();
            //    My_CPersonlist = (List<CPerson>)My_BinaryFormatter.Deserialize(My_FileStream);
            //    for (int i = 0; i < My_CPersonlist.Count; i++)
            //    {
            //        My_CPersonlist[i].vAusgabe();
            //    }   

            //    if (My_CPersonlist.Count == 0)
            //    {
            //        MessageBox.Show("Es wurden noch keine Daten angelegt!", "Lehrer Schüler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Fehler beim Laden der Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //Neues Design
                                                    //this: zeiger auf das Formular frm_Registierung
            frm_Ausgabe My_frmAusgabe = new frm_Ausgabe();//Erzeugendes Formular frm_Ausgabe
            this.Visible = false;//this: Zeiger auf frm_Registrierung
            My_frmAusgabe.Show();

        }

    }
}
