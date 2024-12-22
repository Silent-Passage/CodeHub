#include<iostream>

using namespace std;


int main()
{
	const int c_iAnzahl = 10;
	float arr_fZahlen[c_iAnzahl] = {};
	int iErgebniss = 0;
	char cAuswahl = ' ';
	int imax;
	int imin;
	int ihaufig;
	float fsumme;
	char cWiederholung = ' ';

	do
	{

		cout << "Geben Sie " << c_iAnzahl << " Werte ein: " << endl;

		cout << "____________________________" << endl;

		for (int i = 0; i < c_iAnzahl; i++)
		{
			cout << "Geben Sie den " << i + 1 << ". Wert ein: " << endl;
			cin >> arr_fZahlen[i];

			cout << "_______________________" << endl;
		}
		do
		{
			cout << "Geben Sie die gew" << char(129) << "nschte Option an" << endl;
			cout << "[M] Mittelwert" << endl;
			cout << "[G] Gr" << char(148) << char(225) << "ter Wert" << endl;
			cout << "[K] Kleinster Wert" << endl;

			cin >> cAuswahl;

			switch (cAuswahl)
			{
			case('M'):
			{
				cout << "Mittelwert: " << endl;

				for (int i = 0; i < c_iAnzahl; i = i++)
				{

				}

					
				

				}
			case('G'):
			{
				if (c_iAnzahl[1] > c_iAnzahl[2]);
				cout << "Der Erste Wert ist der gr" << char(148) << char(225) << "te Wert" << endl;
			}













			}
			










			cout << endl << endl << "Wenn Sie das Programm mit neuen Werten wiederholen wollen, dr" << char(129) << "cken Sie [n]" << endl;
			cout << "Wenn Sie das Programm mit den gleichen Werten wiederholen wollen; dr" << char(129) << "cken Sie [o]" << endl;

			

		
		} while (cOldRepeat == 'o');

	} while (cNewRepeat == 'n');

	return 0;
}

