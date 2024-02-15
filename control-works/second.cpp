#include <iostream>
#include <cmath>

int main() {
    double x, y, s;

    std::cout << "Enter value x: ";
    std::cin >> x;

    std::cout << "Enter value y: ";
    std::cin >> y;

    if (x - y == 0) {
        s = pow(x, 2) + pow(cbrt(y), 3) + sin(y);
        std::cout << "Computation branch selected x - y = 0" << std::endl;
    } else if (x - y > 0) {
        s = pow(x - y, 2) + log(abs(x));
        std::cout << "Computation branch selected x - y > 0" << std::endl;
    } else {
        s = pow(y - x, 2) + tan(y);
        std::cout << "Computation branch selected x - y < 0" << std::endl;
    }

    std::cout << "Result: " << s << std::endl;

    return 0;
}