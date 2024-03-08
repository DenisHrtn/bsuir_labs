#include <iostream>

const int MAX_SIZE = 100;

void swap(int& a, int& b) {
    int temp = a;
    a = b;
    b = temp;
}

int main()
{
    bool is_admin = true;
    std::cout << is_admin;
}