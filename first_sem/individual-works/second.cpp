#include <iostream>

using namespace std;

const int N = 3;
const int M = 4;

int main() {
    int matrix[N][M] = {{34, -99, 1, -8},
                        {-1, 0, 7, -21},
                        {7, -1, 15, -2}};

    int sumMinus = 0;

    cout << "Matrix:\n";
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++) {
            cout << matrix[i][j] << " ";
            if (j > N - i - 1 && matrix[i][j] < 0) {
                sumMinus += matrix[i][j];
            }
        }
        cout << "\n";
    }
    cout << "Sum of negative elements above the secondary diagonal: " << sumMinus << "\n";

    return 0;
}