//================================================
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.
//=================================================


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

int QuterTest(int X, int Y)
{
    if (X > 0 && Y > 0)
        return 1;
    if (X > 0 && Y < 0)
        return 2;

    if (X < 0 && Y < 0)
        return 3;

    if (X < 0 && Y > 0)
        return 4;

    return -1;
}

void PrintResult(string line)
{
    Console.Write(line);
}

int X = ReadData("Введите координату X: ");
int Y = ReadData("Введите координату Y: ");

int res = QuterTest(X, Y);

PrintResult("Точка находится в четверти №: " + res);
