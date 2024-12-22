#include<iostream>
#include<vector>

using namespace std;

int main()
{
	vector<float> vec_fZahlen;
	float fEingabe = 0;
	char cAbbruch = 'n';
	char cAuswahl = ' ';
	float fsumme = 0;
	int iErgebniss = 0;
	char cWiederholung = ' ';

	
	


	cout << "Geben Sie beliebig viele Zahlen ein" << endl;
	cout << "Mit der 0 koenen Sie die Eingabe beenden!" << endl;
	do
	{
		cin >> fEingabe;
		if (fEingabe == 0)
			{

			cout << "Wollen Sie die Eingabe abbrechen (a) oder die 0 hinzufuegen?" << endl;
			cin >> cAbbruch;
			if (cAbbruch != 'a')
			{
				vec_fZahlen.push_back(fEingabe);
			}
		}
		else
		{
			vec_fZahlen.push_back(fEingabe);
		}

	} while (cAbbruch != 'a');

	
	do
	{
		cout << "Bitte waehlen sie die gewuenste Operation aus : " << endl;
		cout << "[m] Mittelwert" << endl;
		cout << "[g] groesste Wert" << endl;
		cout << "[k] kleinste Wert" << endl;


		cin >> cAuswahl;


		switch (cAuswahl)
		{
			case('m'):
			{
				cout << "Mittelwert:" << endl;

				for (int i = 0; i < vec_fZahlen.size(); i = i++)
				{
					fsumme += vec_fZahlen[i];
				}
				iErgebniss = fsumme
					/ vec_fZahlen.size();

				cout << "Das ergebnis ist: " << iErgebniss << endl;
				break;
			}
			case('g'):
			{
				int num;
				int max = vec_fZahlen[0];
				for (num = 0; num < vec_fZahlen.size(); num++)
				{
					if (max < vec_fZahlen[num])
						max = vec_fZahlen[num];
				}
				cout << "Der Groesste Wert der eingegebenen Werte betraegt: " << max << endl;

				break;
			}
			case('k'):
			{
				int num;
				int min = vec_fZahlen[0];
				for (num = 0; num < vec_fZahlen.size(); num++)
				{
					if (min > vec_fZahlen[num])
						min = vec_fZahlen[num];
				}

				cout << "Der kleinste Wert der eingegebenen Werte betraegt: " << min << endl;
				break;
			}
		}
	} while (cWiederholung == 'a');
		
											
	return 0;
}