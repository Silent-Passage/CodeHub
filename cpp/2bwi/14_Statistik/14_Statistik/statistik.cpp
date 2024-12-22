#include <iostream>

using namespace std;
int main()
{
	char cWiederholung = 'n';
	char cWiederholung2 = 'n';
	const int c_iAnzahl = 10;
	float arr_fZahlen[c_iAnzahl] = {};
	char cStatistik = 'a';
	float fErgebnis = 0;
	float fErgebnis1 = 0;
	do {
		cout << "Geben Sie die " << c_iAnzahl << " Werte ein: \n" << endl;

		for (int i = 0; i < c_iAnzahl; i++)
		{
			cout << "Geben Sie den " << i + 1 << ". Wert ein: " << endl;
			cin >> arr_fZahlen[i];
		}

		do 
		{
			cout << "_____________________________________________________________" << endl;

			cout << "Waehlen Sie einen der 3 moeglichen Statistik-Werten" << endl;
			cout << "[m]-> Mittelwert" << endl;
			cout << "[g]-> groesster Wert" << endl;
			cout << "[k]-> kleinster Wert" << endl;

			cin >> cStatistik;

			cout << "_____________________________________________________________" << endl;

			switch (cStatistik)
			{
			case 'm':
			{
				cout << "Berechnung des Mittelwertes von den Oben eingegebenen Zahlen: " << endl << endl;

				for (int i = 0; i != c_iAnzahl; i++)
				{
					fErgebnis += arr_fZahlen[i];
				}

				cout << "Der Mittelwert der eingegebenen Werte betraegt: " << fErgebnis / c_iAnzahl << endl;
				break;
			}
			case 'g':
			{
				cout << "Berechnung des groessten Wertes von den Oben eingegebenen Zahlen: " << endl << endl;

				int num;
				int max = arr_fZahlen[0];
				for (num = 0; num < 10; num++)
				{
					if (max < arr_fZahlen[num])
						max = arr_fZahlen[num];
				}

				cout << "Der groesste Wert der eingegebenen Werte betraegt: " << max << endl;
				break;
			}
			case 'k':
			{

				cout << "Berechnung des kleinsten Wertes von den Oben eingegebenen Zahlen: " << endl << endl;

				int num;
				int min = arr_fZahlen[0];
				for (num = 0; num < 9; num++)
				{
					if (min > arr_fZahlen[num])
						min = arr_fZahlen[num];
				}

				cout << "Der kleinste Wert der eingegebenen Werte betraegt: " << min << endl;
				break;
			}

			default:
			{
				cout << "Bitte geben Sie einen der oben angeschriebenen Werte ein..." << endl;
				break;
			}
			}

			cout << endl;
			cout << "Wollen sie das Programm wiederholen?" << endl;
			cout << "Ja mit neuen Zahlen => [j]" << endl;
			cout << "Ja mit alten Zahlen => [a]" << endl;
			cout << "Nein [n]" << endl;
			cin >> cWiederholung;
			system("cls");
			

		} while (cWiederholung == 'a');
		
	} while (cWiederholung == 'j');

	system("taskkill /f /im vsdebugconsole.exe");

	return 0;
} 
