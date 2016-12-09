#include <iostream>
#include <fstream>
#include <vector>
#include <string>

class Triangle {
    int sides[3];

    public:
};

bool IsValidTriangle(const int sides[])
{
    return (sides[0] + sides[1] > sides[2] &&
            sides[2] + sides[1] > sides[0] &&
            sides[0] + sides[2] > sides[1]);
}

int ValidTriangles(std::ifstream& file) 
{
    int numValid = 0;
    int sides[3];
    while (!file.eof()) {
        file >> sides[0] >> sides[1] >> sides[2];
        if (IsValidTriangle(sides)) {
            ++numValid;
        }
    }
    return numValid;
}

int main()
{
    std::ifstream file;
    file.open("input.txt");

    std::cout << ValidTriangles(file);
}