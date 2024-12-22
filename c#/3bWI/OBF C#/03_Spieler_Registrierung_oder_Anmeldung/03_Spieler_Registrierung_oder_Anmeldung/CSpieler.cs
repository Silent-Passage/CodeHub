using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Spieler_Registrierung_oder_Anmeldung
{
    [Serializable()]
    public class CSpieler
    {
        public string strVorname { get; set; }
        public string strNachname { get; set; }
        public string strPasswort { get; set; }
        public string strPasswortBestaetigen { get; set; }

        public CSpieler()
        {
            this.strVorname = string.Empty;
            this.strNachname = string.Empty;
            this.strPasswort = string.Empty;
            this.strPasswortBestaetigen = string.Empty;
        }
        public CSpieler(string strVornameK, string strNachnameK, string strPasswortK, string strPasswortBestaetigenK)
        {
            this.strVorname = strVornameK;
            this.strNachname = strNachnameK;
            this.strPasswort = strPasswortK;
            this.strPasswortBestaetigen = strPasswortBestaetigenK;
        }
        public CSpieler(string strVornameK, string strNachnameK, string strPasswortK)
        {
            this.strVorname = strVornameK;
            this.strNachname = strNachnameK;
            this.strPasswort = strPasswortK;
        }
        
    }
}
