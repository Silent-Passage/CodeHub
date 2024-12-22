#include <iostream>

using namespace std;



int main()
{
	//Ausgabe aller ganzen Zahlen von -21 bis 32

	for (int i = -21; i < 33; i = i++) // i++ ist i=i+1; ++Inktiminator
	{
		cout << i << endl;
	}


	system("Pause");
	system("cls");


	//Ausgabe aller ganzen Zahlen von 15 bis -8

	for (int i = 15; i > -9; i = i - 1) // i-- ist i=i-1; +-Dekremenator
	{
		cout << i << endl;
	}


	system("Pause");
	system("cls");


	//Ausgabe aller geraden Zahlen von 12 bis 29


	for (int i = 12; i <= 29; i = i + 2)
	{
		cout << i << endl;
	}

	system("Pause");
	system("cls");

	//Ausgabe aller Zahlen zwischen 200 und 280, die durch 11 teilbar sind

	//mein lösung:

/*	for (int i = 209; i <= 280; i = i + 11)
	{
		cout << i << endl;
	}
*/



	for(int i = 200; i < 280; i++)
	{
			if (i % 11 == 0)					//% ..... Modulo-Operator: Gibt bei einer Division den Rest zurück

			{
				cout << i << endl;
			}
	}



	system("Pause");
	system("cls");


	//Ausgabe aller Zahlen zwischen 0 und 100, die durch 7 und 3 teilbar sind

	for (int i = 0; i < 100; i++)
	{
		if (i % 7 == 0 && i % 3 == 0)
		{
			cout << i << endl;
		}


	}



	return 0;
}