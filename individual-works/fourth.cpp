#include <iostream>

using namespace std;


void fillArray(int** arr, int n) {
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
            {
                if (i % 5 <= 2 && j % 5 <= 2)
                {
                    arr[i][j] = 2;
                } else {
                    arr[i][j] = 3;
                }
            } else
            {
                if (i % 7 <= 4 && j % 7 >= 5)
                {
                    arr[i][j] = 5;
                } else {
                    arr[i][j] = 4;
                }
            }
        }
    }
}

void printArray(int** arr, int n) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++)
        {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
}

int perimeterSum(int** arr, int n) {
    int sum = 0;

    // Верхняя граница
    for (int j = 0; j < n; j++)
    {
        sum += arr[0][j];
    }

    // Правая граница
    for (int i = 1; i < n - 1; i++)
    {
        sum += arr[i][n - 1];
    }

    // Нижняя граница
    for (int j = n - 1; j >= 0; j--)
    {
        sum += arr[n - 1][j];
    }

    // Левая граница
    for (int i = n - 2; i > 0; i--)
    {
        sum += arr[i][0];
    }

    return sum;
}

int main() {
    int n;
    cout << "Введите размерность матрицы: ";
    cin >> n;

    int** a = new int*[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = new int[n];
    }

    int** b = new int*[n];
    for (int i = 0; i < n; i++)
    {
        b[i] = new int[n];
    }

    fillArray(a, n);
    fillArray(b, n);

    cout << "Матрица A:" << endl;
    printArray(a, n);

    cout << "Матрица B:" << endl;
    printArray(b, n);

    int sumA = perimeterSum(a, n);
    int sumB = perimeterSum(b, n);

    cout << "Сумма элементов по периметру матрицы A: " << sumA << endl;
    cout << "Сумма элементов по периметру матрицы B: " << sumB << endl;

    for (int i = 0; i < n; i++)
    {
        delete[] a[i];
    }
    delete[] a;

    for (int i = 0; i < n; i++)
    {
        delete[] b[i];
    }
    delete[] b;

    return 0;
}