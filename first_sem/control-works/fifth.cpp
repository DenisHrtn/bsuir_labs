#include <iostream>
#include <cmath>

int main() {
    double a = 0.5;
    double b = 0.6;
    double h = 0.01;

    std::cout << "x\t\tf(x)\n";
    std::cout << "---------------------\n";

    for (double x = a; x <= b; x += h) {
        double result = 1 + exp(x);
        std::cout << x << "\t\t" << result << std::endl;
    }

    return 0;
}