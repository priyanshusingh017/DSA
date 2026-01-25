#include<iostream>
#include<bits/stdc++.h>
using namespace std;

int gcd(int a , int b){
    // base 
    if(b==0) return a;
    return gcd(b,b%a);
}
int main() {
    int a = 36, b = 60;
    cout << "GCD of " << a << " and " << b << " is " << gcd(a, b) << endl;
    return 0;
}
