#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double start = 0.0; // Начало интервала
    double end = 1.0; // Конец интервала

    int numParts;
    cout << "Введите количество частей для разделения области поиска: ";
    cin >> numParts;

    double step = (end - start) / numParts; // Шаг

    double min = start + step; // Предполагаемый минимальный корень
    double minVal = asin(min) - min + pow(min, 2) - 1; // Значение функции для предполагаемого минимального корня

    for (double x = start + step * 2; x <= end; x += step) {
        double val = asin(x) - x + pow(x, 2) - 1;

        if (abs(val) < abs(minVal)) { // Если найдено значение функции меньшее по модулю
            minVal = val;
            min = x;
        }
    }

    cout << "Корень уравнения f(x) = 0: x = " << min << endl;

    return 0;
}