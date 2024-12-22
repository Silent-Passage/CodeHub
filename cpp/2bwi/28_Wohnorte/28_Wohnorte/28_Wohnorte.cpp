#include <iostream>
#include <vector>
#include <string>

using namespace std;

struct stru_Schueler {
    string nachname;
    string wohnort;
    int geburtsjahr;
};

vector<stru_Schueler> Eingabe() {
    vector<stru_Schueler> schueler_liste;
    stru_Schueler schueler;

    do {
        cout << "Geben Sie einen Nachnamen ein ('0' zum Beenden): ";
        cin >> schueler.nachname;
        if (schueler.nachname != "0") {
            cout << "Geben Sie den Wohnort ein: ";
            cin >> schueler.wohnort;
            cout << "Geben Sie das Geburtsjahr ein: ";
            cin >> schueler.geburtsjahr;
            schueler_liste.push_back(schueler);
        }
    } while (schueler.nachname != "0");

    return schueler_liste;
}

vector<stru_Schueler> Filter(vector<stru_Schueler> schueler_liste, string wohnort) {
    vector<stru_Schueler> gefilterte_liste;

    for (int i = 0; i < schueler_liste.size(); i++) {
        if (schueler_liste[i].wohnort == wohnort) {
            gefilterte_liste.push_back(schueler_liste[i]);
        }
    }

    return gefilterte_liste;
}

int main() {
    vector<stru_Schueler> schueler_liste;

    string wiederholen;
    do {
        schueler_liste = Eingabe();

        string wohnort;
        cout << "Geben Sie einen Wohnort ein, um die Schuelerdaten zu filtern: ";
        cin >> wohnort;
        system("cls");
        vector<stru_Schueler> gefilterte_liste = Filter(schueler_liste, wohnort);

        cout << "Gefilterte Schuelerdaten fuer Wohnort " << wohnort << ":" << endl;
        for (int i = 0; i < gefilterte_liste.size(); i++) {
            cout << "Nachname: " << gefilterte_liste[i].nachname << endl;
            cout << "Wohnort: " << gefilterte_liste[i].wohnort << endl;
            cout << "Geburtsjahr: " << gefilterte_liste[i].geburtsjahr << endl;
            cout << "---------------------------------" << endl;
        }

        cout << "Moechten Sie das Programm mit alten oder neuen Daten wiederholen?" << endl;
        cout << "[a] Ja mit alten Daten" << endl;
        cout << "[n] Ja mit neuen Daten" << endl;
        cout << "[q] Nein" << endl;
        cin >> wiederholen;
        system("cls");
    } while (wiederholen != "q");

    return 0;
}