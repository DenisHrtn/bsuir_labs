#include <iostream>
#include <cmath>

int main() {
    // объявление переменнных
    float z, a, b;
    char phi;

    // вывод сообщений для выбора и вводы данных в консоль
    std::cout << "Enter value z: ";
    std::cin >> z;

    std::cout << "Select function phi(z):" << std::endl;
    std::cout << "1. 2z" << std::endl;
    std::cout << "2. sqrt(z)^3" << std::endl;
    std::cout << "3. z/3" << std::endl;
    std::cout << "Your choice: ";
    std::cin >> phi;

    std::cout << "Enter value a: ";
    std::cin >> a;

    std::cout << "Enter value b: ";
    std::cin >> b;

    float x;
    switch (phi) {
        case '1':
            x = 2 * z;
            std::cout << "Calculations were performed with the function phi(z) = 2z" << std::endl;
            break;
        case '2':
            x = pow(sqrt(z), 3);
            std::cout << "Calculations were performed with the function phi(z) = sqrt(z)^3" << std::endl;
            break;
        case '3':
            x = z / 3;
            std::cout << "Calculations were performed with the function phi(z) = z/3" << std::endl;
            break;
        default:
            std::cout << "Wrong choice of function!" << std::endl;
            return 0;
    }

    float y = -M_PI * x + a * pow(cos(x),2) + b * pow(sin(x), 3);
    std::cout << "Value y: " << y << std::endl;

    return 0;
}