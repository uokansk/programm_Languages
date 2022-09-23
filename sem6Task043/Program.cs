/////////////////////////////////////////////////
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
// b1, k1, b2 и k2 задаются пользователем.
/////////////////////////////////////////////////


// ввод данных
double ReadData(string line)
{
    Console.Write(line);
    double number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[] PointFind(double b1, double b2, double k1, double k2)
{
    double[] outArr = new double[3];

    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    // double y2 = k2 * x + b2; // для проверки
    outArr[0] = x;
    outArr[1] = y;
    return outArr;
}

// метод вывода массива
void PrintArray(double[] outArr)
{
    Console.Write("[" + outArr[0] + ", ");
    for (int i = 1; i < 1; i++)
    {
        Console.Write(outArr[i] + ", ");
    }
    Console.WriteLine(outArr[1] + "]");
    Console.WriteLine();
}

// ввести данные
double b1 = ReadData("Введите b1: ");
double b2 = ReadData("Введите b2: ");
double k1 = ReadData("Введите k1: ");
double k2 = ReadData("Введите k2: ");


PrintArray(PointFind(b1,b2,k1,k2));
