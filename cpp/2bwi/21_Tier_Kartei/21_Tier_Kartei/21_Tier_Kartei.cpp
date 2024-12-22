#include <iostream>
#include <vector>
#include <string>

using namespace std;

struct stru_Tier
{
    string strTiername;
    int iBeine = 0;
    float fGroesse = 0;
};

int main()
{
    vector <stru_Tier> vec_Tiere;
    stru_Tier struTier;
    char cWiederholung = 'a';
    string strPuffer = "";

    do
    {
        cout << "Um das Programm zu stoppen, x im Tiernamen eingeben" << endl;
        cout << "-----------------------------------------------------------" << endl;

        do
        {
            if (cWiederholung == 'j')
            {
                getline(cin, strPuffer);
            }
            cout << "Name Ihres " << vec_Tiere.size() + 1 << ". Tieres ein: ";
            getline(cin, struTier.strTiername);
            
            



            if (struTier.strTiername != "x")
            {
                cout << endl << "Anzahl der Beine Ihres " << vec_Tiere.size() + 1 << ". Tieres ein: ";
                cin >> struTier.iBeine;

                cout << endl << "Gr" << char(148) << char(225) << "e Ihres " << vec_Tiere.size() + 1 << ". Tieres: ";
                cin >> struTier.fGroesse;

                vec_Tiere.push_back(struTier);

                getline(cin, strPuffer);
            }
            system("cls");

        } while (struTier.strTiername != "x");

        cout << "-----------------------------------------------------------" << endl;

        for (int i = 0; i < vec_Tiere.size(); i++)
        {
            cout << "Tiername:\t\t" << vec_Tiere[i].strTiername << endl;
            cout << "Anzahl der Beine:\t" << vec_Tiere[i].iBeine << endl;
            cout << "Gr" << char(148) << char(225) << "e:\t\t\t" << vec_Tiere[i].fGroesse << endl;
            cout << "-----------------------------------------------------------" << endl;
        }
        cout << endl << "M"<<char(148)<<"chten Sie das Programm wiederholen ? [j]" << endl;
        cin >> cWiederholung;
        system("cls");

    } while (cWiederholung == 'j');

    system("taskkill /f /im vsdebugconsole.exe");
    return 0;
}