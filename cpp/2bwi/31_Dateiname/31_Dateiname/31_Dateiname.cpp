#include<iostream>
#include<string>
#include<fstream>

using namespace std;

int main()
{
	fstream datDatei;
	string strDateiname = "";

	cout << "Bitte geben Sie den Dateinamen ein: " << endl;
	getline(cin, strDateiname);
	strDateiname = strDateiname + ".txt";
	//Funktioniert auch ohne .c_str()
	datDatei.open(strDateiname.c_str(), ios::in); //Umwandlung in einen C-String

	if (datDatei)
	{
		datDatei << "Jawohl";
		cout << "Datei konnte erfolgreich erstellt werden!" << endl;
	}
	else
	{
		cout << "Datei konnte nicht erstellt werden!" << endl;
	}

	return 0;
}