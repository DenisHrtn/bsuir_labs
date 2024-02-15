#include <iostream>
#include <cmath>

float calculateX(float z, char phi) {
    switch (phi) {
        case '1':
            return 2 * z;
        case '2':
            return pow(sqrt(z), 3);
        case '3':
            return z / 3;
        default:
            return 0;
    }
}

float calculatePhi(float x, float a, float b) {
    return -M_PI * x + a * pow(cos(x), 2) + b * pow(sin(x), 3);
}

int main() {
    float z, a, b;
    char phi;

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

    float x = calculateX(z, phi);
    std::cout << "Calculations were performed with the selected function." << std::endl;

    float y = calculatePhi(x, a, b);
    std::cout << "Value y: " << y << std::endl;

    return 0;
}