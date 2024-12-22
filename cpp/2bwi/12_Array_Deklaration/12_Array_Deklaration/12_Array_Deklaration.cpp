//Deklaration, Initialisierung und Ausgabe eines eindimensionales Array
#include<iostream>

using namespace std;


int main()
{

	//Deklaration und Initialisierung
	int arr_iZahlen[7] = { 1, 34 }; //Initialisierung des Restes mit Null

	//Ausgabe: Kompliziert
	cout << arr_iZahlen[0] << endl;
	cout << arr_iZahlen[1] << endl;
	cout << arr_iZahlen[2] << endl;
	cout << arr_iZahlen[3] << endl;
	cout << arr_iZahlen[4] << endl;
	cout << arr_iZahlen[5] << endl;
	cout << arr_iZahlen[6] << endl;
	//cout<<arr_iZahlen[7]<<endl;
	cout << "_______________________________________________" << endl;
	//Ausgabe: Elegant
	//Anzahl der Elemente
	for (int iTindex = 7; iTindex >= 0; iTindex--)
	{
		cout << arr_iZahlen[iTindex] << endl;
	}
	
	cout << "_______________________________________________" << endl;
	//Deklaration eines Arrays: Elegant
	const int const_iAnzahlZeilen = 15;//Deklaration einer Konstanten
	//Deklaration des Arrays
	int arr_iZahlen1[const_iAnzahlZeilen] = { 3,7,4,9,-2,5,76,2 };//Initialisierung

	for (int i = 0; i < const_iAnzahlZeilen; i++)//Konstante als Begrenzung der Schleife
	{
		cout << arr_iZahlen1[i] << endl;

	}

	return 0;
}