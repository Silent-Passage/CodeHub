#include<iostream>
#include<string>


using namespace std;

int main()
{
	char cWiederholung = 'n';
	char cWiederholung2 = 'n';
	string strZeichenkette = "";
	string strPuffer = "";
	char cZeichenkette = 'a';
	char cAltes = 0;
	char cNeues = 0;
	string strTemporaer = "";
	
	do 
	{	
		cout << "Geben Sie bitte Ihre Zeichenkette ein: " << endl;
		getline(cin, strZeichenkette);
		cout << "_____________________________________________________________" << endl;
		
		do
		{
			if (cWiederholung == 'a')
			{
				cout << "Alte Zeichenkette: " << strZeichenkette << endl;

				cout << "_____________________________________________________________" << endl;
			}

			cout << "Geben Sie bitte das Zeichen ein was ersetzt werden soll: " << endl;
			cin >> cAltes;
			
			cout << "_____________________________________________________________" << endl;

			cout << "Geben Sie bitte ein welches Zeichen durch " << cAltes << " eingesetzt werden soll" << endl;
			cin >> cNeues;
			
				
			system("cls");

			strTemporaer = strZeichenkette;

				for (int i = 0; i < strZeichenkette.size(); i++)
				{
					if (strZeichenkette[i] == cAltes)
					{
						strZeichenkette[i] = cNeues;
					}
					else if (strZeichenkette[i] == char(int(cAltes) - 32))
					{
						strZeichenkette[i] = char(int(cNeues) - 32);
					}
				}



				if (strZeichenkette != strTemporaer)
				{
					cout << strZeichenkette << endl;
				}
				else
				{
					cout << "Das Zeichen ist nicht in der Zeichenkette vorhanden!" << endl;
				}

			cout << "_____________________________________________________________" << endl;

			cout << endl;
			cout << "Wollen Sie das Programm wiederholen?" << endl;
			cout << "Ja mit neuer Zeichenkette => [j]" << endl;
			cout << "Ja mit alter Zeichenkette => [a]" << endl;
			cout << "Nein [n]" << endl;
			cin >> cWiederholung;
			system("cls");
	
		} while (cWiederholung == 'a');
		
		getline(cin, strPuffer);

	} while (cWiederholung == 'j');

	system("taskkill /f /im vsdebugconsole.exe");

	return 0;
}