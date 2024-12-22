#include <iostream>
#include <vector>
#include <string>
#include<cmath>

using namespace std;

struct struct_Vornamen
{
    string strVorname;
    string strNachname;
    float fAlter = 0;
};

int main()
{
    vector <struct_Vornamen> vec_Vorname;
    struct_Vornamen struct_Vornamen;
    string strWiederholung = "";
    string strVornameRandom;
    string strPuffer = "";
    char cAuswahl = ' ';
    float fSumme = 0;
    float fDurchschnittshoehe = 0;
    int iZaehler = 0;
    float fProzent = 0;

    do
    {
        do
        {
        cout << "Um das Programm zu stoppen, x eingeben" << endl;
        cout << "-----------------------------------------------------------" << endl << endl;

        
        
            cout << vec_Vorname.size() + 1 << ". Vorname:\t";
            getline(cin, struct_Vornamen.strVorname);

            if (struct_Vornamen.strVorname != "x")
            {
                cout << vec_Vorname.size() + 1 << ". Nachname:\t";
                getline(cin, struct_Vornamen.strNachname);
                
                cout << vec_Vorname.size() + 1 << ". Alter:\t";
                cin >> struct_Vornamen.fAlter;

                vec_Vorname.push_back(struct_Vornamen);

                getline(cin, strPuffer);

            }
            system("cls");

        } while (struct_Vornamen.strVorname != "x");

        cout << "-----------------------------------------------------------" << endl;

        do
        {

        
            for (int i = 0; i < vec_Vorname.size(); i++)
            {
                cout << "Vorname:\t\t" << vec_Vorname[i].strVorname << endl;
                cout << "Nachname:\t\t" << vec_Vorname[i].strNachname << endl;
                cout << "Alter:\t\t\t" << vec_Vorname[i].fAlter << endl;
                cout << "-----------------------------------------------------------" << endl << endl;
            }

        
        
            cout << "Durchschnittsalter von allen Alter [p]" << endl;
            cout << "Prozentueller Anteil gleicher Vornamen [d]" << endl;
            cin >> cAuswahl;
            system("cls");

            switch (cAuswahl)
            {
                case('p'):
                {
                    for (int i = 0; i < vec_Vorname.size(); i++)
                    {
                        fSumme = fSumme + vec_Vorname[i].fAlter;
                        iZaehler++;
                    }
                    fDurchschnittshoehe = fSumme / iZaehler;
                    cout << "-----------------------------------------------------------" << endl;
                    cout << "Das Durschnittsalter betr" << char(132) << "gt: " << fDurchschnittshoehe << endl;
                }
                break;

                case('d'):
                {
                    cout << endl << "Von welchem Vornamen m" << char(148) << "chten Sie den Prozentuellen Anteil berechnen?" << endl;
                    cout << "--------------------------------------------------------------------" << endl;
                    cin >> strVornameRandom;
                    getline(cin, strPuffer);
                    system("cls");


                    for (int i = 0; i < vec_Vorname.size(); i++)
                    {
                        if (vec_Vorname[i].strVorname == strVornameRandom)
                        {
                            fSumme = fSumme + 1;
                            
                            
                        }
                    }
                    fProzent = round((fSumme / vec_Vorname.size()) * 100);

                    cout << "-----------------------------------------------------------" << endl;
                    cout << "Der Vorname " << strVornameRandom << " macht " << fProzent << "% von dem Gesamtwert aus" << endl;
                }
                break;
            }

            cout << "-----------------------------------------------------------" << endl;
            cout << endl << "M" << char(148) << "chten Sie das Programm wiederholen ?" << endl;
            cout << "-----------------------------------------------------------" << endl;
            cout << "Ja mit alten Daten [k]" << endl;
            cout << "Ja mit neuen Daten [j]" << endl;
            cout << "Nein               [n]" << endl << endl;
            cin >> strWiederholung;
            getline(cin, strPuffer);
            system("cls");

            fSumme = 0;

        } while (strWiederholung == "k");

        vec_Vorname.clear();
        iZaehler = 0;
        fSumme = 0;

    } while (strWiederholung == "j");

    system("taskkill /f /im vsdebugconsole.exe");
    return 0;
}