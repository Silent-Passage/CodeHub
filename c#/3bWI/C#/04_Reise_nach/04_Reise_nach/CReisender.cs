namespace _04_Reise_nach
{
    internal class CReisender
    {
        private string _strVorname;
        private string _strNachname;
        private string _strAufenthaltsort;

        public string strVorname
        {
            get { return _strVorname; }
            set { _strVorname = value; }
        }

        public string strNachname { get; set; }

        public string strAufenthaltsort { get; set; }

        public bool bKontrolle(string strReiseziel)
        {
            return strReiseziel == strAufenthaltsort;
        }
    }

}