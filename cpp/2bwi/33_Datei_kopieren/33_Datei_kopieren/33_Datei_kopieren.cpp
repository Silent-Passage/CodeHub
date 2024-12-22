#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
    fstream dataDatei;
    string strQuellpfad = "D:\\Test";
    string strZielpfad = "D:\\Test2";
    string strZeile;
    string strDateiname;

    cout << "Bitte geben Sie den Namen der Datei ein:" << endl;
    getline(cin, strDateiname);

    strQuellpfad = strQuellpfad + "\\" + strDateiname + ".txt";
    strZielpfad = strZielpfad + "\\" + strDateiname + ".txt";
   
    dataDatei.open(strQuellpfad, ios::in);
    if (dataDatei) {
    
        fstream zielDatei(strZielpfad, ios::out);
        if (zielDatei) {
    
            while (getline(dataDatei, strZeile)) {
                zielDatei << strZeile << endl;
            }

            cout << "Datei erfolgreich kopiert." << endl;
            zielDatei.close();
        }
        else {
            cout << "Fehler beim Öffnen der Zieldatei." << endl;
        }

        dataDatei.close();
    }
    else {
        cout << "Fehler beim Öffnen der Quelldatei." << endl;
    }

    return 0;
}
