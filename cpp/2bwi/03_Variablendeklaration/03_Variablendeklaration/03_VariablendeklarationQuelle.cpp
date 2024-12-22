/*In diesem Programm werden Variable deklariert und Initialisiert*/

#include<iostream>

using namespace std;

int main()
{
	int iZahl = 12; //Deklaration und Initalisierung
	int iSummand = 0;
	int iSumme = 0;


	// Ausgabe einer Variblen
	 
	cout << "Die Zahl lautet: " << iZahl << endl;


	//Eingabe einer Zahl 


	cout << "Geben Sie bitte eine Zahl ein: ";
	cin >> iZahl;
	system("pause");
	cout << "Die neue Zahl lautet:" << iZahl << endl;




	cout << "Bitte geben Sie einen Wert ein, der zur Zahl hinzuaddiert werden soll:";
	cin >> iSummand;
	


	//1. Variante
	//iSumme = iZahl + iSummand;
	//cout << "Die Summe = " << iSumme << endl;

	//2. Variante
	cout << "Die Summe = " << iZahl + iSummand << endl;

	return 0;

}