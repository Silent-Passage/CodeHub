using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Spieler_Registrierung_oder_Anmeldung
{
    public partial class frm_Anmeldung : Form
    {
        frm_Auswahl My_frmAuswahl = new frm_Auswahl();
        public frm_Anmeldung(frm_Auswahl frmAuswahl)
        {
            My_frmAuswahl = frmAuswahl;
            InitializeComponent();
        }
        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string strAktion;
        public frm_Anmeldung(string strAktion, frm_Auswahl frmAuswahl)  
        {
            InitializeComponent();
            this.strAktion = strAktion;
            My_frmAuswahl = frmAuswahl;

            if (strAktion == "Anmelden")
            {
                btn_Aktion.Text = "Anmelden";
            }
            else if (strAktion == "Registrieren")
            {
                btn_Aktion.Text = "Registrieren";
            }
        }
        List<CSpieler> SpielerListe = new List<CSpieler>();

        private void btn_Aktion_Click(object sender, EventArgs e)
        {
            btn_Aktion_Click(sender, e, SpielerListe);
        }
        private void btn_Aktion_Click(object sender, EventArgs e, IEnumerable<CSpieler> spielerListe)
        {
            if (strAktion == "Anmelden")
            {
                string strVorname = tb_Vorname.Text;
                string strNachname = tb_Nachname.Text;
                string strPasswort = tb_Passwort.Text;

                if (tb_Vorname.Text == String.Empty)
                {
                    MessageBox.Show("Bitte geben Sie den Vornamen des Spielers ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Vorname.Focus();
                }
                else if (tb_Nachname.Text == String.Empty)
                {
                    MessageBox.Show("Bitte geben Sie den Nachnamen des Spielers ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Nachname.Focus();
                }
                else if (tb_Passwort.Text == String.Empty)
                {
                    MessageBox.Show("Bitte geben Sie das Passwort des Spielers ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Passwort.Focus();
                } 
                else
                {
                    CSpieler gefundenerSpieler = null;
                    if (File.Exists("spielerdaten.xml"))
                    {
                        using (FileStream My_FileStream = new FileStream("spielerdaten.xml", FileMode.Open))
                        {
                            XmlSerializer My_XmlSerializer = new XmlSerializer(typeof(List<CSpieler>));
                            SpielerListe = (List<CSpieler>)My_XmlSerializer.Deserialize(My_FileStream);
                        }

                        gefundenerSpieler = SpielerListe.FirstOrDefault(spieler => spieler.strVorname == strVorname && spieler.strNachname == strNachname);

                        if (gefundenerSpieler != null)
                        {
                            if (EntschluesselePasswort(gefundenerSpieler.strPasswort) == strPasswort)
                            {
                                MessageBox.Show("Spieler wurde gefunden und geladen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Passwort ungültig!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Spieler wurde noch nicht registriert!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Spieler wurde noch nicht registriert!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string strVorname = tb_Vorname.Text;
                string strNachname = tb_Nachname.Text;
                string strPasswort = tb_Passwort.Text;
                string strPasswortBestaetigen = tb_Passwort_bestaetigen.Text;

                if (tb_Vorname.Text == String.Empty)
                {
                    MessageBox.Show("Bitte geben Sie den Vornamen des Spielers ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Vorname.Focus();
                }
                else if (tb_Nachname.Text == String.Empty)
                {
                    MessageBox.Show("Bitte geben Sie den Nachnamen des Spielers ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Nachname.Focus();
                }
                else if (tb_Passwort.Text == String.Empty)
                {
                    MessageBox.Show("Bitte geben Sie das Passwort des Spielers ein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Passwort.Focus();
                }
                else if (tb_Passwort_bestaetigen.Text == String.Empty)
                {
                    MessageBox.Show("Passwörter des Spielers stimmen nicht überein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Passwort_bestaetigen.Focus();
                }
                else if (tb_Passwort.Text != tb_Passwort_bestaetigen.Text)
                {
                    MessageBox.Show("Passwörter des Spielers stimmen nicht überein!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Passwort_bestaetigen.Focus();
                }
                else
                {
                    if (File.Exists("spielerdaten.xml"))
                    {
                        using (FileStream My_Filestream = new FileStream("spielerdaten.xml", FileMode.Open))
                        {
                            XmlSerializer My_XmlSerializer = new XmlSerializer(typeof(List<CSpieler>));
                            SpielerListe = (List<CSpieler>)My_XmlSerializer.Deserialize(My_Filestream);
                        }
                    }
                    bool SpielerVorhanden = SpielerListe.Any(spieler => spieler.strVorname == strVorname && spieler.strNachname == strNachname);

                    if (SpielerVorhanden)
                    {
                        MessageBox.Show("Spieler ist schon registriert!", "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CSpieler My_CSpieler = new CSpieler(strVorname, strNachname, VerschluesselePasswort(strPasswort));
                        try
                        {
                            SpielerListe.Add(My_CSpieler);

                            using (FileStream My_Filestream = new FileStream("spielerdaten.xml", FileMode.Create))
                            {
                                XmlSerializer My_XmlSerializer = new XmlSerializer(typeof(List<CSpieler>));
                                My_XmlSerializer.Serialize(My_Filestream, SpielerListe);
                            }

                            MessageBox.Show("Spieler wurde registriert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Speichern der Spielerdaten: " + ex.Message, "Hilfe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        public static string CaesarVerschiebung(string text, int verschiebung)
        {
            string strCaesarverschiebung = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetterOrDigit(c) || IsSpecialChar(c))
                {
                    char cStart;
                    int offset;
                    if (char.IsLetter(c))
                    {
                        cStart = char.IsUpper(c) ? 'A' : 'a';
                        offset = 26;
                    }
                    else if (char.IsDigit(c))
                    {
                        cStart = '0';
                        offset = 10;
                    }
                    else // It's a special character
                    {
                        cStart = (char)32; // Start of ASCII special characters
                        offset = 15; // Number of supported special characters in ASCII
                    }
                    strCaesarverschiebung += (char)((((c + verschiebung) - cStart + offset) % offset) + cStart);
                }
                else
                {
                    strCaesarverschiebung += c;
                }
            }
            return strCaesarverschiebung;
        }
        // Function to check if a character is a supported special character
        private static bool IsSpecialChar(char c)
        {
            char[] specialChars = { '!', '"', '#', '$', '%', '&', ' ', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', ']', '^', '_', '`', '{', '|', '}', '~' };        
            return specialChars.Contains(c);
        }
        private string VerschluesselePasswort(string passwort)
        {
            int verschluesselungsSchluessel = 5; // Deine gewünschte Verschiebung
            // Verschlüssele das Passwort und gib es zurück
            return CaesarVerschiebung(passwort, verschluesselungsSchluessel);
        }
        private string EntschluesselePasswort(string verschluesseltesPasswort)
        {
            int verschluesselungsSchluessel = -5; // Negative Verschiebung, um zu entschlüsseln
            // Entschlüssele das Passwort und gib es zurück
            return CaesarVerschiebung(verschluesseltesPasswort, verschluesselungsSchluessel);
        }
        private void frm_Anmeldung_Load(object sender, EventArgs e)
        {
            if (strAktion == "Anmelden")
            {
                lb_Passwort_bestaetigen.Visible = false;
                tb_Passwort_bestaetigen.Visible = false;
            }
        }
        private void frm_Anmeldung_FormClosed(object sender, FormClosedEventArgs e)
        {
            My_frmAuswahl.Visible = true;
        }     
    }
}