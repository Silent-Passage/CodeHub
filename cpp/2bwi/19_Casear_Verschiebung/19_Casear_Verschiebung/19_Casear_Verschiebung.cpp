#include<iostream>
#include<string>


using namespace std;

int main()
{
	string strZeichenkette2 = "";
	string strZeichenkette = "";
	string strPuffer = "";
	char cAuswahl = ' ';
	char cAuswahl2 = ' ';
	int iVerschiebung = 0;
	char cTempZeichen = ' ';
	int iTempZahl = 0;
	char cWiederholung = 'n';

	do
	{	
		cout << "Text verschl"<< char(129)<<"sseln [a]" << endl;
		cout << "Text entschl" << char(129) << "sseln [b]" << endl;
		cout << "_____________________________________________________________" << endl;
		cin >> cAuswahl;
		system("cls");

		switch (cAuswahl)
		{
			case('a'):
			{
				getline(cin, strPuffer);
				cout << "Bitte gebe Sie Ihren Text ein zum Verschl" << char(129) << "sseln: " << endl;
				cout << "_____________________________________________________________" << endl;
				getline(cin, strZeichenkette);

				cout << endl << "Um wie viele Positionen nach rechts sollen die Zeichen verschoben werden: " << endl;
				cout << "_____________________________________________________________" << endl;
			
				cin >> iVerschiebung;
			
				cout << "Verschl"<<char(129)<<"sselter Text: ";
				
				for (int i = 0; i < strZeichenkette.size(); i++)
				{
					iTempZahl = strZeichenkette[i];
					cTempZeichen = int(iTempZahl);
					cTempZeichen = cTempZeichen + iVerschiebung;
					iTempZahl = char(cTempZeichen);
					strZeichenkette[i] = iTempZahl;
					
				}
				system("cls");
				cout << strZeichenkette;
			}		
			break;

			case('b'):
			{
				int iVerschiebung = 1;
				getline(cin, strPuffer);
				cout << "Bitte gebe Sie Ihren verschl" << char(129) << "sselten Text ein: " << endl;
				cout << "_____________________________________________________________" << endl;
				getline(cin, strZeichenkette2);
				
				cout << endl << "Entschl" << char(129) << "sselung mit eigener Verschiebung [k]" << endl;
				cout << "Entschl" << char(129) << "sselung mit immer steigender Verschiebung [d]" << endl;
				cout << "_____________________________________________________________" << endl;
				cin >> cAuswahl2;
				system("cls");

				switch (cAuswahl2)
				{
					case('d'):
					{
						do
						{
							system("cls");
							for (int i = 0; i < strZeichenkette2.size(); i++)
							{
								
								iTempZahl = strZeichenkette2[i];
								cTempZeichen = int(iTempZahl);
								cTempZeichen = cTempZeichen - iVerschiebung;
								iTempZahl = char(cTempZeichen);
								strZeichenkette2[i] = iTempZahl;

							}

							cout << strZeichenkette2 << endl;

							cout << "______________________" << endl;
							cout << "Stimmt Ihr Text?" << endl;
							cout << "Ja [j]" << endl;
							cout << "Nein [n]" << endl << endl;
							cin >> cWiederholung;
							cout << "______________________" << endl;
						} while (cWiederholung == 'n');

						system("cls");
						cout << "Entschl" << char(129) << "sselter Text : " << strZeichenkette2;
					}
					break;

					case('k'):
					{
						cout << "Um wie viele Positionen nach links sollen die Zeichen verschoben werden: " << endl;
						cout << "_____________________________________________________________" << endl;

						cin >> iVerschiebung;

						for (int i = 0; i < strZeichenkette2.size(); i++)
						{
							
							iTempZahl = strZeichenkette2[i];
							cTempZeichen = int(iTempZahl);
							cTempZeichen = cTempZeichen - iVerschiebung;
							iTempZahl = char(cTempZeichen);
							strZeichenkette2[i] = iTempZahl;

						}
						cout << strZeichenkette2 << endl;

						system("cls");
						cout << "Entschl" << char(129) << "sselter Text : " << strZeichenkette2;
					}
					break;
				}
			}	
			break;
		}
		
		cout << endl << "_____________________________________________________________" << endl;

		cout << "Wollen Sie das Programm wiederholen?" << endl;
		cout << "Ja [j]" << endl;
		cout << "Nein [n]" << endl << endl;
		cin >> cWiederholung;
		system("cls");

	} while (cWiederholung == 'j');
			
	system("taskkill /f /im vsdebugconsole.exe");

	return 0;
}