#include <iostream>
using namespace std;

int main() {
    char choice;
    double dBreite;
    double dLänge;
    double dHöhe;
    double dErgebniss;

    cout << "Wähle eine Form um den Flächeninhalt zu berechnen" << endl;
    cout << "1. Quadrat" << endl;
    cout << "2. Rechteck" << endl;
    cout << "3. Deltoid" << endl;
    cout << "4. Trapez" << endl;
    cin >> choice;

    switch (choice) {
    case '1':
        cout << "Gib die Laenge ein fuer das Quadrat: ";
        cin >> dLänge;
        dErgebniss = dLänge * dLänge;
        break;
    case '2':
        cout << "Gib die Breite und Laenge ein für das Rechteck: ";
        cin >> dBreite >> dLänge;
        dErgebniss = dBreite * dLänge;
        break;
    case '3':
        cout << "Gib die Breite und Laenge ein für den Deltoid: ";
        cin >> dBreite >> dLänge;
        dErgebniss = (dBreite * dLänge) / 2.0;
        break;
    case '4':
        cout << "Gib die Hoehe, Breite und Laenge ein für den Trapez ";
        cin >> dHöhe >> dBreite >> dLänge;
        dErgebniss = ((dBreite + dLänge) / 2.0) * dHöhe;
        break;
    default:
        cout << "Fehler bei der Eingabe, bitte wählen sie zwischen: 1, 2, 3, 4";
        return 0;
    }
    cout << "Der Flächeninhalt beträgt: " << dErgebniss << endl;
    return 0;
}