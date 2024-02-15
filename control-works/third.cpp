#include <iostream>
#include <cmath>
using namespace std;


int main() {
    double x;
    short int n, amt,i=1;
    cout << "Enter n and amt: " << endl;
    cin >> n >> amt;
    do {
        int s = 1;
        double sum = 1.0;
        cout << "Enter x: " << endl;
        cin >> x;
        double m_cand = pow(M_E, (x * cos(M_PI / 4)));
        double factor = cos(x * sin(M_PI / 4));
        do {
            int fact = 1;
            for (int z = 1; z <= s; ++z) {                // факториал
                fact *= z;
            }
            sum += (cos(s * (M_PI / 4)) / fact) * pow(x, s);       // ряд тейлора
            s++;
        } while (s <= n);
        cout << m_cand * factor << endl;
        cout << sum << endl;
        i++;
    } while (i <= amt);

    return 0;
}