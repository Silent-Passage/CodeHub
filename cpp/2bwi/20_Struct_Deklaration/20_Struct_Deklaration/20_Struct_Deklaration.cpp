#include <iostream>
#include <string>
#include <vector>

using namespace std;
//Globaler Bereich

//Neuer Datentyp, erzeugt im globalen Bereich
struct stru_Person //Datentypname: stru_Person
{
    int iAlter;
    string strVorname;
    string strNachname;
};

int main()
{
    string strPuffer = "";
    //Datentyp //Variable
    stru_Person struPerson; //Variable vom Datentyp stru_Person

    //system("color 92");

    cout << "Geben sie bitte das Alter der Person ein:" << endl;
    cin >> struPerson.iAlter; //Auf die inneren Daten wird mit Hilfe des Punktoperators zugegriffen
    system("cls");

    cout << "Geben sie bitte den Vornamen der Person ein:" << endl;

    getline(cin, strPuffer);
    getline(cin, struPerson.strVorname);
    system("cls");

    cout << "Geben sie bitte den Nachnamen der Person ein" << endl;

    getline(cin, struPerson.strNachname);
    system("cls");

    cout << "Ihre Person hei" << char(225) << "t " << struPerson.strVorname << " " << struPerson.strNachname << " und ist " << struPerson.iAlter << " Jahre alt." << endl;
    
    return 0;
}