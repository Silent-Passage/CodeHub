//In diesem Programm werden beliebig viele Zahlen ein- und Ausgabe
#include<iostream>
#include<vector>
using namespace std;
















int main()
{
	vector<float> vec_fZahlen;//Vector vom Datentyp float, Initialisierung nicht notwendig , weil er leer ist
	float fEingabe = 0;
	char cAbbruch = 'n';

	//1. Variante: umständlich, da nach jeder Eingabe für eine weitere Eingabe
	//ein beliebiges Zeichen eingegeben werde muss.
	//-------------------------------------------------------------------------
	do
	{
		cout << "Geben Sie eine beliebige Zahl ein:" << endl;
		cin >> fEingabe;
		vec_fZahlen.push_back(fEingabe);
		cout << "Wollen Sie die Eingabe beenden? (j)" << endl;
		cin >> cAbbruch;
	
	} while (cAbbruch != 'j');//Bleibt in der Schleife wenn "nicht" j eingegeben wird
	
	for (int i = 0; i < vec_fZahlen.size(); i++)
	{
		cout << vec_fZahlen[i] << endl;
	}

	//2. Variante ------------------------------------------------------------

	//cout << "Geben Sie eine beliebige Zahl ein"	<< endl;
	//cout << "Mit der 0 koenen Sie die Eingabe beenden!" << endl;
	//do
	//{
	//	cin >> fEingabe;
	//	if (fEingabe == 0)
	//	{
	//		//Soll 0 zum Vector hinzugefügt werden?
	//		cout << "Wollen Sie die Eingabe abbrechen (a) oder die 0 hinzufuegen?" << endl;
	//		cin >> cAbbruch;
	//		if (cAbbruch != 'a') //Ist kein 'a' eingebeben worden
	//		{
	//			vec_fZahlen.push_back(fEingabe);
	//		}
	//	}
	//	else
	//	{
	//		vec_fZahlen.push_back(fEingabe);
	//	}

	//} while (cAbbruch != 'a');

	//for (int i = 0; i < vec_fZahlen.size(); i++)
	//{
	//	cout << vec_fZahlen[i] << endl;
	//}


	("pause");
	return 0;
}	