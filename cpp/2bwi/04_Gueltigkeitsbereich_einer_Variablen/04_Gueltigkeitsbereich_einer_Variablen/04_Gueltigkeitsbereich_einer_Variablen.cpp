#include<iostream>

using namespace std;

int main()
{
	int iZahl = 12;
	{
		int iZahl1 = 4;//iZahl ist nur in diesem und folgendem Unterblock gültig
		cout << iZahl << endl;
		{
			int iZahl = 34;
			cout << iZahl << endl;
			{
				int iZahl = 89;
			}
		}
	}


	return 0;
}