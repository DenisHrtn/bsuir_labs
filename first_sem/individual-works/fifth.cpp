#include <iostream>

using namespace std;


int main() {
    const int MAX_LENGTH = 80;
    char input[MAX_LENGTH];

    cout << "Введите строку из нулей и единиц: ";
    cin.getline(input, MAX_LENGTH);

    int maxGroupLength = 0;
    int currentGroupLength = 0;
    char maxGroupSymbol;

    for (int i = 0; input[i] != '\0'; i++) {
        if (input[i] == '0' || input[i] == '1') {
            if (currentGroupLength == 0 || input[i] != input[i - 1]) {
                currentGroupLength = 1;
            } else {
                currentGroupLength++;
            }

            if (currentGroupLength > maxGroupLength) {
                maxGroupLength = currentGroupLength;
                maxGroupSymbol = input[i];
            }
        }
    }

    cout << "Исходная строка: " << input << std::endl;
    cout << "Символ самой длинной группы: " << maxGroupSymbol << std::endl;
    cout << "Длина самой длинной группы: " << maxGroupLength << std::endl;

    return 0;
}