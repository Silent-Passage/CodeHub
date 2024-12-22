#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	ofstream datZiel; //Dateiobjekt zum schreiben
	ifstream datQuelle; //Dateiobjekte zum Lesen
	fstream datTextdatei;
	string strEingabe = "";
	string strAusgabe = "";

	//Texteingabe
	cout << "Bitte geben Sie einen Text ein: " << endl;
	getline(cin, strEingabe);

	//Speichern des Textes
	datZiel.open("text.txt", ios::out);
	if(datZiel) //Konnte die Datei geöffnet werden?

	{
		datZiel << strEingabe; //Schreiben der Daten
		datZiel.close(); //Datei schließen
	}
	else
	{
		cout << "Die Datei konnte nicht geöffnet werden!" << endl; //Fehlermeldung
	}

	//Auslesen des Textes aus der Datei
	system("pause");
	
	cout << "Nun wird die Datei ausgelesen:" << endl;

	datQuelle.open("text.txt", ios::in);
	if (datQuelle)
	{
		getline(datQuelle, strAusgabe);
		cout << endl << strAusgabe << endl;
		datQuelle.close();
	}
	else
	{
		cout << endl << "Datei konnte nicht geöffnet werden!" << endl;		
	}

	return 0;
}