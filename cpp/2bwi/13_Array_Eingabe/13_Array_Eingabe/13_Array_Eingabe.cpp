//In diesem projekt wird ein Array mit Hilfe einer Schleife gefüllt
//und wieder ausgegeben
#include<iostream>

using namespace std;


int main()
{
	const int c_iAnzahl = 5;
	float arr_fZahlen[c_iAnzahl] = {};

	cout << "Geben Sie " << c_iAnzahl << " Werte ein: " << endl;

	cout << "____________________________" << endl;

	for(int i = 0; i < c_iAnzahl; i++)
	{
		cout << "Geben Sie den " << i + 1 << ". Wert ein: "<<endl;
		cin >> arr_fZahlen[i];

		cout << "_______________________" << endl;
	}
	for (int i = 0; i < c_iAnzahl; i++) 
		
	{
		cout << i + 1 << ". Wert: " << arr_fZahlen[i] << endl;

		cout << "_______________________" << endl;
	}

	return 0;
}