#include<iostream>
#include<cmath>

using namespace std;


double Sqrt(double x) {
    return sqrt(x);
}

void f(int n) 
{
    double root2 = Sqrt(n);
    cout << "The root from "<< n <<": " << root2 << endl;
}

int main() 
{
    int n;
    cout << "Input ur Number: ";
    cin >> n;
    f(n);
    return 0;
}
