//In diesem Programm werden drei Zahlen eingegeben und es wird
//ermittelt, welche die groesste Zahl.
#include <iostream>

using namespace std;

int main() //Einsprungpunkt des Programms: Hauptfunktion
{
		float fZahl1 = 0;
		float fZahl2 = 0;
		float fZahl3 = 0;
		char cWiederholung = 'j';
	do{
		// Die Zahlen werden eingegebne und verglichen ob sie gleich sind

		cout << "Bitte geben Sie die erste Zahl ein: " << endl;
		cin >> fZahl1;
		do 
		{
			cout << "Bitte geben Sie die zweite Zahl ein: " << endl;
			cin >> fZahl2;
			if (fZahl2 == fZahl1)
			{
				cout << "Die Zahlen muessen verschieden sein !!! (ERROR 404: Mach was gschits)" << endl;
			}

		} while (fZahl1 == fZahl2);



		do
		{
			cout << "Bitte geben Sie die dritte Zahl ein: " << endl;
			cin >> fZahl3;

			if (fZahl3 == fZahl1 || fZahl3 == fZahl2) // || bedeutet "oder"!!!!!!!
			{
				cout << "Die zahlen muessen unterschiedlich sein!!!!!! (du depp)" << endl;
			}
			
		} while (fZahl3 == fZahl2 || fZahl3 == fZahl2);


		// Zahlen werden unten verglichen

		if (fZahl1 > fZahl2)
		{
			if (fZahl1 > fZahl3)
			{
			cout << "Zahl 1 ist am groessten: " << fZahl1 << endl;
			}

			else
			{
				cout << "Zahl 3 ist am groessten: " << fZahl3 << endl;
			}
		}
		else
		{
			if (fZahl2 > fZahl3)
			{
				cout << "Zahl 2 ist am groessten: " << fZahl2 << endl;
			}

			else
			{
				cout << "Zahl 3 ist am groessten: " << fZahl3 << endl;
			}
		}


		cout << endl << "Wollen Sie das Programm wiederholen? (j)" << endl;
		//Abfrage und Schleife für die Wiederholung
		cin >> cWiederholung;
		system("cls");


	} while (cWiederholung == 'j'); // == bedeutet "vergleichen"!!!

	return 0;
}