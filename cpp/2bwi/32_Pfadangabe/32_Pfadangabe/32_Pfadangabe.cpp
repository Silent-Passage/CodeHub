#include<iostream>
#include<string>
#include<fstream>

using namespace std;

int main()
{
	fstream datDatei;
	string strDateiname = "";
	string strDateipfad = "D:\\2bWI";

	cout << "Bitte geben Sie den Dateinamen ein: " << endl;
	getline(cin, strDateiname);
	strDateiname = strDateiname + ".txt";
	strDateipfad = strDateipfad + "\\";
	
	datDatei.open(strDateiname, ios::in); 

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