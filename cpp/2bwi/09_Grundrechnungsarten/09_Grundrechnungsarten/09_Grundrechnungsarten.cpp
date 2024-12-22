#include<iostream>

using namespace std;

int main()
{
	float fZahl1 = 0;
	float fZahl2 = 0;
	float fResult = 0;
	char cCalculator;
	char cRepeat = 'y';
	char cRechner;

	do 
	{
		cout << "Geben Sie die gewuenschte Rechenart ein" << endl;
		cout << "[a] Addition" << endl;
		cout << "[s] Subtraktion" << endl;
		cout << "[m] Multiplikation" << endl;
		cout << "[d] Division" << endl;

		cin >> cRechner;

		switch (cRechner)
		{
		case('a'):
			{
				cout << "Bitte geben Sie den ersten Summanden ein" << endl;
				cin >> fZahl1;
				cout << "Bitte geben Sie den zweiten Summanden ein" << endl;
				cin >> fZahl2;

				fResult = fZahl1 + fZahl2;
				cout << "Das Ergebniss lautet " << fResult << endl;
				break;
			}

		case('s'):
			{
				cout << "Bitte geben Sie den ersten Minuend ein" << endl;
				cin >> fZahl1;
				cout << "Bitte geben Sie den zweiten Minuend ein" << endl;
				cin >> fZahl2;

				fResult = fZahl1 - fZahl2;
				cout << "Das Ergebniss lautet " << fResult << endl;
				break;
			}

		case('m'):
			{
				cout << "Bitte geben Sie den ersten Faktor ein" << endl;
				cin >> fZahl1;
				cout << "Bitte geben Sie den zweiten Faktor ein" << endl;
				cin >> fZahl2;

				fResult = fZahl1 * fZahl2;
				cout << "Das Ergebnis lautet " << fResult << endl;
				break;
			}

		case('d'):
			{
				cout << "Bitte geben Sie den Dividend ein" << endl;
				cin >> fZahl1;
				cout << "Bitte geben Sie den Divisor ein" << endl;
				cin >> fZahl2;

				if (fZahl2 == 0)
				{
					cout << "Der Divisior kann nicht 0 sein" << endl;
				}
				else
				{
					fResult = fZahl1 / fZahl2;
					cout << "Das Ergebnis lautet " << fZahl1 << " / " << fZahl2 << " lautet " << fResult << endl;
				}
				break;
			}

		}
			cout << endl << endl << "Wenn Sie das Programm wiederholen wollen, dann druecken Sie [y]" << endl;

			cin >> cRepeat;
			system("cls");
		
	} while (cRepeat == 'y');


	return 0;
}