#include <iostream>
using namespace std;

int main() {
    char choice;
    double dBreite;
    double dL�nge;
    double dH�he;
    double dErgebniss;

    cout << "W�hle eine Form um den Fl�cheninhalt zu berechnen" << endl;
    cout << "1. Quadrat" << endl;
    cout << "2. Rechteck" << endl;
    cout << "3. Deltoid" << endl;
    cout << "4. Trapez" << endl;
    cin >> choice;

    switch (choice) {
    case '1':
        cout << "Gib die Laenge ein fuer das Quadrat: ";
        cin >> dL�nge;
        dErgebniss = dL�nge * dL�nge;
        break;
    case '2':
        cout << "Gib die Breite und Laenge ein f�r das Rechteck: ";
        cin >> dBreite >> dL�nge;
        dErgebniss = dBreite * dL�nge;
        break;
    case '3':
        cout << "Gib die Breite und Laenge ein f�r den Deltoid: ";
        cin >> dBreite >> dL�nge;
        dErgebniss = (dBreite * dL�nge) / 2.0;
        break;
    case '4':
        cout << "Gib die Hoehe, Breite und Laenge ein f�r den Trapez ";
        cin >> dH�he >> dBreite >> dL�nge;
        dErgebniss = ((dBreite + dL�nge) / 2.0) * dH�he;
        break;
    default:
        cout << "Fehler bei der Eingabe, bitte w�hlen sie zwischen: 1, 2, 3, 4";
        return 0;
    }
    cout << "Der Fl�cheninhalt betr�gt: " << dErgebniss << endl;
    return 0;
}