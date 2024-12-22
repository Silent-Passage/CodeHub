#include<iostream>
#include<string>

using namespace std;

int main()
{
	int iAlter = 0;
	string strPuffer = "";
	string strVorname = "";
	string strNachname = "";
	string strVorNachname = "";
	string strWhitespace = "";
	int i = 0, j = 0, m;
	char c[50];

	cout << "Geben Sie bitte Ihren Vornamen ein: ";
	getline(cin, strVorname);

	cout << "Geben Sie bitte Ihr Alter an: ";
	cin >> iAlter;
	getline(cin, strPuffer);//Tastaturpuffer wird geleert

	cout << "Geben Sie bitte Ihren Nachnamen ein: ",
	getline(cin, strNachname);

	cout << endl << strVorname;
	cout << endl << iAlter;
	cout << endl << strNachname;

	//Verkettung von Zeichenketten 

	strVorNachname = strVorname + " " + strNachname;

	cout << endl << strVorNachname << endl;

	for (int i = 0; i < strVorNachname.size(); i++)
	{
		cout << strVorNachname[i] << endl;
	}

	for (int i = 0; i < strVorNachname.size(); i++)
	{
		strWhitespace = strWhitespace + " ";
		cout << strWhitespace << strVorNachname[i] << endl;
	}
















	return 0;
}