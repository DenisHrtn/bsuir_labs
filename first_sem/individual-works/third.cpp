#include <iostream>

using namespace std;


int main() {
    int N, M;
    cout << "Enter the number of rows (N): ";
    cin >> N;

    cout << "Enter the number of columns (M): ";
    cin >> M;

    int** matrix = new int*[N];
    for (int i = 0; i < N; i++)
    {
        matrix[i] = new int[M];
    }

    cout << "Enter the matrix elements:\n";
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            cin >> matrix[i][j];
        }
    }

    int maxElement = matrix[0][0];
    int maxElementRow = 0;
    int maxElementCol = 0;

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (matrix[i][j] > maxElement)
            {
                maxElement = matrix[i][j];
                maxElementRow = i;
                maxElementCol = j;
            }
        }
    }

    int* tempRow = matrix[0];
    matrix[0] = matrix[maxElementRow];
    matrix[maxElementRow] = tempRow;

    for (int i = 0; i < N; i++)
    {
        int temp = matrix[i][0];
        matrix[i][0] = matrix[i][maxElementCol];
        matrix[i][maxElementCol] = temp;
    }

    cout << "Initial matrix:\n";
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            cout << matrix[i][j] << " ";
        }
        cout << "\n";
    }

    cout << "Matrix after rearrangement:\n";
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            cout << matrix[i][j] << " ";
        }
        cout << "\n";
    }

    for (int i = 0; i < N; i++)
    {
        delete[] matrix[i];
    }
    delete[] matrix;

    return 0;
}