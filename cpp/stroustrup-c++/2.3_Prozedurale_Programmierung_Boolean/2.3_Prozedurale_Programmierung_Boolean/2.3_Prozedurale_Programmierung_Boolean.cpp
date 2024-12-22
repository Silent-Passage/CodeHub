#include <iostream>

using namespace std;

bool accept()
{
	cout << "Moechten Sie weitermachen? (y/n)" << endl;
	char antwort = 0;
	cin >> antwort;
	switch (antwort)
	{
	case'y':
		return false;
	case'n':
		return true;
	default:
		cout << "Bitte geben Sie einen richtigen Wert ein" << endl;
		return true;
	}
}
int main()
{
	while (!accept()) 
	{
		cout << "0" << endl;
	}

	return 0;
}

