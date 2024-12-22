#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string strAbbruch = "";
	fstream datTextdatei;
	string strEingabe = "";
	string strAusgabe = "";

	cout << "Bitte geben Sie Ihren Text ein:" << endl;
	cout << "Wenn Sie fertig mit der Eingabe fertig sind  'a' fuer Abbruch ein!" << endl;

	datTextdatei.open("Textspeicher.txt", ios::app);
	if (datTextdatei)
	{
		do
		{
			getline(cin, strEingabe);
			if (strEingabe == "a")
			{
				cout << "Wollen Sie die Eingabe wirklich beenden 'j'?" << endl;
				getline(cin, strAbbruch);
				if (strAbbruch != "j")
				{
					datTextdatei << strEingabe + "\n";// \n ... Zeilenumbruch
				}
			}
			else
			{
				datTextdatei << strEingabe + "\n";// Text wird gespeichert
			}
		} while (strAbbruch != "j");
		datTextdatei.clear();
		datTextdatei.close();
	}
	else
	{
		cout << "Die Datei konnte nicht geöffnet werden!" << endl;
	}

	//Offnen der Datei um den Text auszulesen

	datTextdatei.open("Textspeicher.txt", ios::in);

	while (datTextdatei.eof() == false)
	{
		getline(datTextdatei, strAusgabe);
		cout << endl << strAusgabe << endl;
	}
	datTextdatei.close();

	system("pause");
	return 0;
}