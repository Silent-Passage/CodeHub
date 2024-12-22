#include <iostream>
#include <vector>

using namespace std;


vector <float> fGleichungsystem1(vector <float> vecVariablen);
vector <float> fGleichungsystem2(vector <float> vecVariablen2);


int main()
{
	float fVariable = 0;
	vector <float> vecWerte;
	vector <float> vecErebnisse;
	float fEingabe = 0;
	char cAuswahl = ' ';
	

	cout << "Welches Gleichungsystem wollen Sie berechnen lassen?" << endl;
	cout << "[2] Gleichungsystem mit 2 Unbekannten" << endl;
	cout << "[3] Gleichungsystem mit 3 Unbekannten" << endl;
	cin >> cAuswahl;
	switch (cAuswahl)
	{
		case('2'):
		{
			cout << "Gib fuer das folgende Gleichungssystem die Variablen [a]/[b]/[c]/[d]/[e]/[f] ein:" << endl;
			cout << "a*x + b*y = c" << endl;
			cout << "d*x + e*y = f" << endl << endl;

			cout << "Gib einen Wert fuer [a] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [b] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [c] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [d] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [e] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [f] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			/*for (int i = 0; i < vecWerte.size(); i++)
			{
				cout << vecWerte[i] << endl;
			}*/


			vecErebnisse = fGleichungsystem1(vecWerte);

			cout << "X = " << vecErebnisse[0] << endl;
			cout << "Y = " << vecErebnisse[1] << endl;


			break;
		}



		case('3'):
		{
			cout << "Gib fuer das folgende Gleichungssystem die Variablen [a]/[b]/[c]/[d]/[e]/[f]/[g]/[h]/[i]/[j]/[k]/[l] ein:" << endl;
			cout << "a*x + b*y + c*z = d" << endl;
			cout << "e*x + f*y + g*z = h" << endl;
			cout << "i*x + j*y + k*z = l" << endl;

			cout << "Gib einen Wert fuer [a] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [b] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [c] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [d] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [e] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [f] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [g] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [h] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [i] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [j] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [k] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);

			cout << "\nGib einen Wert fuer [l] ein: " << endl;
			cin >> fEingabe;
			vecWerte.push_back(fEingabe);



			vecErebnisse = fGleichungsystem2(vecWerte);

			cout << "X = " << vecErebnisse[0] << endl;
			cout << "Y = " << vecErebnisse[1] << endl;
			cout << "Z = " << vecErebnisse[2] << endl;


			break;
		}

		default:
		{
			cout << "error" << endl;

			break;
		}


	}


	


	

	return 0;
}


vector <float> fGleichungsystem1(vector <float> vecVariablen)
{
	vector <float> vecErgebnissevonFunktion;
	
	float fDeterminate = 0;
	float fXDeterminate = 0;
	float fYDeterminate = 0;
	float fX = 0;
	float fY = 0;

	
	fDeterminate = (vecVariablen[0] * vecVariablen[4]) - (vecVariablen[1] * vecVariablen[3]);

	fXDeterminate = (vecVariablen[2] * vecVariablen[4]) - (vecVariablen[1] * vecVariablen[5]);

	fYDeterminate = (vecVariablen[0] * vecVariablen[5]) - (vecVariablen[2] * vecVariablen[3]);

	fX = fXDeterminate / fDeterminate;

	fY = fYDeterminate / fDeterminate;


	vecErgebnissevonFunktion.push_back(fX);
	vecErgebnissevonFunktion.push_back(fY);

	return (vecErgebnissevonFunktion);
}


vector <float> fGleichungsystem2(vector <float> vecVariablen2)
{
	vector <float> vecErgebnissevonFunktion2;

	float fDeterminate2 = 0;
	float fXDeterminate2 = 0;
	float fYDeterminate2 = 0;
	float fZDeterminate2 = 0;
	float fX2 = 0;
	float fY2 = 0;
	float fZ2 = 0;

	fDeterminate2  = (vecVariablen2[0] * vecVariablen2[5] * vecVariablen2[10]) + /**/ (vecVariablen2[4] * vecVariablen2[9] * vecVariablen2[2]) + /**/(vecVariablen2[8] * vecVariablen2[1] * vecVariablen2[6]) - /**/(vecVariablen2[8] * vecVariablen2[5] * vecVariablen2[2]) - /**/(vecVariablen2[4] * vecVariablen2[1] * vecVariablen2[10]) - /**/(vecVariablen2[0] * vecVariablen2[9] * vecVariablen2[6]);

	fXDeterminate2 = (vecVariablen2[3] * vecVariablen2[5] * vecVariablen2[10]) + /**/ (vecVariablen2[1] * vecVariablen2[6] * vecVariablen2[11]) + /**/(vecVariablen2[2] * vecVariablen2[7] * vecVariablen2[9]) - /**/(vecVariablen2[11] * vecVariablen2[5] * vecVariablen2[2]) - /**/(vecVariablen2[9] * vecVariablen2[6] * vecVariablen2[3]) - /**/(vecVariablen2[10] * vecVariablen2[7] * vecVariablen2[1]);

	fYDeterminate2 = (vecVariablen2[0] * vecVariablen2[7] * vecVariablen2[10]) + /**/ (vecVariablen2[3] * vecVariablen2[6] * vecVariablen2[8]) + /**/(vecVariablen2[2] * vecVariablen2[4] * vecVariablen2[11]) - /**/(vecVariablen2[8] * vecVariablen2[7] * vecVariablen2[2]) - /**/(vecVariablen2[11] * vecVariablen2[6] * vecVariablen2[0]) - /**/(vecVariablen2[10] * vecVariablen2[4] * vecVariablen2[3]);

	fZDeterminate2 = (vecVariablen2[0] * vecVariablen2[5] * vecVariablen2[11]) + /**/ (vecVariablen2[1] * vecVariablen2[7] * vecVariablen2[8]) + /**/(vecVariablen2[3] * vecVariablen2[4] * vecVariablen2[9]) - /**/(vecVariablen2[8] * vecVariablen2[5] * vecVariablen2[3]) - /**/(vecVariablen2[9] * vecVariablen2[7] * vecVariablen2[0]) - /**/(vecVariablen2[11] * vecVariablen2[4] * vecVariablen2[1]);




	fX2 = fXDeterminate2 / fDeterminate2;

	fY2 = fYDeterminate2 / fDeterminate2;

	fZ2 = fZDeterminate2 / fDeterminate2;

	vecErgebnissevonFunktion2.push_back(fX2);
	vecErgebnissevonFunktion2.push_back(fY2);
	vecErgebnissevonFunktion2.push_back(fZ2);



	return (vecErgebnissevonFunktion2);
}   
