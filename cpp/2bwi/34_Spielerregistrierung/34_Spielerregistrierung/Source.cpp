#include<iostream>
#include<string>
#include<vector>
#include <ctime>
#include <cstdlib>

using namespace std;

struct stru_Spieler
{
	string strVorname = "";
	string strNachname = "";
    int iPunktestand = 0;
    int iID = 0;
};

vector<stru_Spieler>& Registrierung(vector<stru_Spieler>& vec_Spieler)
{
    stru_Spieler stru_Spieler;
    string strPuffer = "";

    getline(cin, strPuffer);
    cout << "Geben Sie Ihre Daten ein!" << endl;
    cout << "-----------------------------------------------" << endl;
    cout << "Vorname:\t";
    getline(cin, stru_Spieler.strVorname);
    cout << "Nachname:\t";
    getline(cin, stru_Spieler.strNachname);
    stru_Spieler.iID = vec_Spieler.size() + 1;

    vec_Spieler.push_back(stru_Spieler);
    return vec_Spieler;
}

void Spielen(vector<stru_Spieler>& vec_Spieler)
{
    srand(static_cast<unsigned int>(time(nullptr)));
    stru_Spieler stru_Spieler;
    int iTempID;
    int iScoreChange;

    cout << "Liste aller registrierten Spieler" << endl;
    for (int i = 0; i < vec_Spieler.size(); i++)
    {
        cout << "-----------------------------------------------" << endl;
        cout << "Vorname:\t" << vec_Spieler[i].strVorname << endl;
        cout << "Nachname:\t" << vec_Spieler[i].strNachname << endl;
        cout << "Punktestand:\t" << vec_Spieler[i].iPunktestand << endl;
        cout << "ID:\t\t" << vec_Spieler[i].iID << endl;
    }
    cout << "-----------------------------------------------" << endl;
    cout << "Geben Sie die ID ein, mit welchem Spieler Sie spielen moechten:\t";
    cin >> iTempID;

    for (int i = 0; i < vec_Spieler.size(); i++)
    {
        if (vec_Spieler[i].iID == iTempID)
        {  
            stru_Spieler = vec_Spieler[i];
            iScoreChange = rand() % 61 - 30;
            stru_Spieler.iPunktestand += iScoreChange;

            cout << endl << "Spieler " << stru_Spieler.strVorname << " " << stru_Spieler.strNachname << " hat " << iScoreChange << " Punkte erhalten." << endl;

            for (int i = 0; i < vec_Spieler.size(); i++)
            {
                if (vec_Spieler[i].iID == iTempID)
                {
                    vec_Spieler[i] = stru_Spieler;
                }
            }    
        }
        else
        {
            cout << endl << "Spieler mit der angegebenen ID wurde nicht gefunden." << endl;
        }
    }
    
}

int main()
{
    vector<stru_Spieler> vec_Spieler;
    char cAuswahl = ' ';
    char cWiederholung = ' ';

    do
    {
        cout << "Was moechten Sie tun?" << endl;
        cout << "-----------------------------------------------" << endl;
        cout << "(r)\tSpieler registrieren" << endl;
        cout << "(s)\tSpielen" << endl << endl;

        cin >> cAuswahl;

        switch (cAuswahl)
        {
        case 'r':
        {
            system("cls");
            vec_Spieler = Registrierung(vec_Spieler);
        }
        break;

        case 's':
        {
            system("cls");
            Spielen(vec_Spieler);
        }
        break;

        default:
        {
            cout << "Es wurde keine gueltige Option gewaehlt" << endl;
        }
        }

        cout << "-----------------------------------------------" << endl;
        cout << "Moechten Sie das Programm wiederholen?" << endl;
        cout << "(y)\tJa" << endl;
        cout << "(n)\tNein" << endl << endl;
        cin >> cWiederholung;
        system("cls");

    } while (cWiederholung == 'y');

    return 0;
}