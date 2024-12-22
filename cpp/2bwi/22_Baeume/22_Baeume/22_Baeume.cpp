#include <iostream>
#include <vector>
#include <string>

using namespace std;

struct stru_Baeume
{
    string strBaumart;
    float fHoehe = 0;
};

int main()
{
    vector <stru_Baeume> vec_Baeume;
    stru_Baeume struBaeume;
    string strWiederholung = "";
    string strPuffer = "";
    string strTempBaum = "";
    float fSumme = 0;
    float fDurchschnittshoehe = 0;
    int iZaehler = 0;
 
    do
    {
            cout << "Geben Sie Ihre Werte ein. Mit (x) wird die Eingabe abgebrochen!" << endl;
            cout << "-----------------------------------------------------------" << endl;

            do
            {
                cout << vec_Baeume.size() + 1 << ". Baumart: ";
                getline(cin, struBaeume.strBaumart);

                if (struBaeume.strBaumart != "x")
                {
                    cout << endl << vec_Baeume.size() + 1 << ". H" << char(148) << "he der " << struBaeume.strBaumart << ": ";
                    cin >> struBaeume.fHoehe;

                    vec_Baeume.push_back(struBaeume);

                    getline(cin, strPuffer);
                }
                system("cls");

            } while (struBaeume.strBaumart != "x");

            cout << "-----------------------------------------------------------" << endl;

            for (int i = 0; i < vec_Baeume.size(); i++)
            {
                cout << "Baumart:\t\t" << vec_Baeume[i].strBaumart << endl;
                cout << "H" << char(148) << "he:\t\t\t" << vec_Baeume[i].fHoehe << endl;
                cout << "-----------------------------------------------------------" << endl;
            }
        do
        {
            cout << endl << "Von welcher Baumart m" << char(148) << "chten Sie die Durchschnittsh" << char(148) << "he berechnen? \n" << endl;

            getline(cin, strTempBaum);

            for (int i = 0; i < vec_Baeume.size(); i++)
            {
                if (vec_Baeume[i].strBaumart == strTempBaum)
                {
                    fSumme = fSumme + vec_Baeume[i].fHoehe;
                    iZaehler++;
                }
            }

            fDurchschnittshoehe = fSumme / iZaehler;

            system("cls");

            cout << "Die Durschnittsh" << char(148) << "he der Baumart " << strTempBaum << " betr" << char(132) << "gt: " << fDurchschnittshoehe << endl;

            cout << "-----------------------------------------------------------" << endl;
            cout << endl << "M" << char(148) << "chten Sie das Programm wiederholen ?" << endl;
            cout << "Mit alten vorhandenen Daten [k]" << endl;
            cout << "Mit neuen eingebaren Daten [y]" << endl;
            cin >> strWiederholung;
            getline(cin, strPuffer);
            system("cls");

        } while (strWiederholung == "k");

            vec_Baeume.clear();
            iZaehler = 0;
            fSumme = 0;

    } while (strWiederholung == "y");

    return 0;
}