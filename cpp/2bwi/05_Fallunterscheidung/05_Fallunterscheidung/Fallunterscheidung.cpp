#include <iostream>

using namespace std;


int main()
{
	char cFarbe = 'a'; 
	char cWiederholung = 'j';

	do
	{

		cout << "Waehlen Sie mit dem entsprechenden Buchstabeneine Farbe aus:" << endl;

		cout << "(g) Gruen" << endl;
		cout << "(r) Rot" << endl;
		cout << "(b) Blau" << endl;
		cout << "(G) Gelb" << endl;


		cin >> cFarbe;


		switch (cFarbe)
		{
		case 'g':
			cout << "Sie haben die Farbe Gruen gewaehlt";
			system("color 02");		//1. Zahl Hintergrundfarbe; 2. Zahl ist die Schriftfarbe
			break;


		case 'r':
			cout << "Sie haben die Farbe Rot gewaehlt";
			system("color 04");
			break;


		case 'b':
			cout << "Sie haben die Farbe Blau gewaelt";
			system("color 01");
			break;


		case 'G':
			cout << "Sie haben die Farbe Gelb gewaelt";
			system("color 06");
			break;

		default: //Fehlermeldung
			cout << "Diese Farbe ist nicht vorhanden du Idiot!" << endl;


		}
		cout << endl << "Wollen Sie das Programm wiederholen? (j)" << endl;
		cin >> cWiederholung;
		system("cls");

	} while (cWiederholung == 'j');
	
	

	




	return 0;
}
