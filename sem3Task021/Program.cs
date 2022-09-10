//++++++++++++++++++++++++++++++++++++++++++++
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
//++++++++++++++++++++++++++++++++++++++++++++++

// чтенеие данных из консоли
int ReadData(string line) // это метод
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}

// вычисляем расстояние между 2 точками
double CalculateData(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2) + (Z1-Z2)*(Z1-Z2));
    return distance;
}

void PrintResult(string line)
{
    Console.Write(line);
}

// ввести данные
int X1 = ReadData("Введите координату X1: ");
int Y1 = ReadData("Введите координату Y1: ");
int Z1 = ReadData("Введите координату Z1: ");
int X2 = ReadData("Введите координату X2: ");
int Y2 = ReadData("Введите координату Y2: ");
int Z2 = ReadData("Введите координату Z2: ");

double res = CalculateData(X1, Y1, Z1, X2, Y2, Z2);

PrintResult(Math.Round(res, 2).ToString());