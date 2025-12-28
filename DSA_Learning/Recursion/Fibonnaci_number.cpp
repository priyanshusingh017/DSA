#include <iostream>
using namespace std;

void fibonnaci_series1(int n)
{

    int a = 0;
    int b = 1;
    cout << a << " " << b << " ";
    for (int i = 2; i < n; i++)
    {
        int c = a + b;
        cout << c << " ";
        swap(a, b);
        swap(b, c);
    }
}

int fibonnaci_series(int n)
{

    // base
    if (n == 0)
        return 0;

    if (n == 1)
        return 1;

    return fibonnaci_series(n - 1) + fibonnaci_series(n - 2);
}

int main()
{

    int n;
    cout << "Enter the number of terms: ";
    cin >> n;
    if (n <= 0)
    {
        cout << "Please enter a positive integer." << endl;
    }
    else
    {
        cout << "Fibonacci sequence (iterative): ";
        fibonnaci_series1(n);
        cout << endl;

        cout << "Fibonacci sequence (recursive): ";
        for (int i = 0; i < n; i++)
        {
            cout << fibonnaci_series(i) << " ";
        }
        cout << endl;
    }
    return 0;
}