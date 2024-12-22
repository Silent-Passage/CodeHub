#include<iostream>

using namespace std;

int main()
{
	int iZahl = 0;
	float fZahl = 1.7f;
	int iZahl1 = 154;
	char cZeichen = ' ';

	iZahl = fZahl; //Implizite (automatische) Datentypumwandlung

	iZahl = static_cast<int> (fZahl); //Erzwungene Datentypumwandlung

	cout << iZahl << endl;

	cZeichen = (char)iZahl1;

	cout << cZeichen << endl;

	cout << "Gott sei dank kann ich in diesem Land w" << char(132) << "hlen" << endl;

	return 0;
}