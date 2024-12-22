#include <iostream>


using namespace std;



int main()
{
	int iStartwert = 0;
	int iEndwert = 0;
	int iSchrittweite = 0;
	char cWiederholung = 'j';


	do {

		cout << "Bitte geben Sie den Startwert ein: " << endl;
		cin >> iStartwert;


		cout << "Bitte geben Sie den Endwert ein: " << endl;
		cin >> iEndwert;



		cout << "Bitte geben Sie die Schrittweite ein" << endl;
		cin >> iSchrittweite;


		for (iStartwert; iStartwert <= iEndwert; iStartwert = iStartwert + iSchrittweite)
		{
			cout << iStartwert << endl;
		}




		cout << endl << "Wollen Sie das Programm wiederholen? (j)" << endl;
		cin >> cWiederholung;
		system("cls");

	} while (cWiederholung == 'j');

	return 0;
}