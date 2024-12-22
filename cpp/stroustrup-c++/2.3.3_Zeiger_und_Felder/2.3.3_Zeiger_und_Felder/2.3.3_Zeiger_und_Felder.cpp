#include <iostream>

using namespace std;

int main()
{
    char v[10] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };//Feld aus 10 char
    char* p;//Zeiger auf char

    cout << "Gib eine Zahl zwischen 0-9 ein" << endl;
    int num = 0;
    cin >> num;
    p = &v[num];

    //einstellige & ist der Adreßoperator
    cout << "Das Element im Array an Stelle " << num << " ist: " << *p << endl;

    return 0;
}