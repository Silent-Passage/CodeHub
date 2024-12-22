#include<iostream>

using namespace std;

int main()
{
	char cZeichen = 0;
	int iAscii = 0;
	char cWiederholung = 'j';
	char cAuswahl = 0;


	do
	{
		cout << "Bitte geben Sie die gew" << char(129) << "nschte Option aus" << endl;
		cout << "[a] Geben Sie eine Zahl ein was in ein Zeichen umgewandelt wird" << endl;
		cout << "[b] Geben Sie ein Zeichen ein was in eine Zahl umgewandelt wird" << endl;

		cin >> cAuswahl;

		switch (cAuswahl)
		{
			case('a'):
			{
				cout << "Bitte geben Sie eine Zahl von 1-255 ein" << endl;
				cin >> iAscii;

				if  (iAscii > 0 && iAscii < 256)
				{
					cout << "Das Zeichen f" << char(129) << "r den ASCII Code ist: " << char(iAscii) << endl;
				}
				else
				{
					cout << "Bitte geben Sie eine Zahl im Bereich von 1-255 ein!" << endl;
				}
				break;
			}
			case('b'):
			{
				cout << "Bitte geben Sie ein Zeichen ein" << endl;
				cin >> cZeichen;

				if (cZeichen < 0)
				{
					cout << "Der ASCII Code f" << char(129) << "r das Zeichen ist: " << int(cZeichen + 256) << endl;
				}
				else
				{
					cout << "Der ASCII Code f" << char(129) << "r das Zeichen ist: " << int(cZeichen) << endl;
				}
				break;
			}
	
		}
			cout << endl << endl << "Wenn Sie das Programm wiederholen wollen, dann dr" << char(129) << "cken Sie [j]" << endl;

			cin >> cWiederholung;
			system("cls");

	} while (cWiederholung == 'j');

	
	return 0;
}