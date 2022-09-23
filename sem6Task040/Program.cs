///////////////////////////////////////////
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
////////////////////////////////////////////

// ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вычисляем расстояние между 2 точками
bool CheckTriangl(int sideA, int sideB, int sideC)
{
    bool result = false;
    if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
    {
        result = true;
    }
    return result;
    // return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
}

//вывод данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int sideA = ReadData("сторона А: ");
int sideB = ReadData("сторона В: ");
int sideC = ReadData("сторона С: ");

PrintResult(CheckTriangl(sideA, sideB, sideC).ToString());

PrintResult(CheckTriangl(sideA, sideB, sideC) ? "Треугольнику быть" : "Не может быть");