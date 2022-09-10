//=====================================================
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).
//=====================================================


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

string QuterBorderAsk(int numberQuter)
{
    if (numberQuter == 1)
        return "x > 0, y > 0";
    if (numberQuter == 2)
        return "x > 0, y < 0";

    if (numberQuter == 3)
        return "x < 0, y < 0";

    if (numberQuter == 4)
        return "x < 0, y > 0";

    return "нет такой четверти";
}

void PrintResult(string line)
{
    Console.Write(line);
}

int numberQuter = ReadData("Введите номер четверти: ");

string res = QuterBorderAsk(numberQuter);

PrintResult("Диапазон " + res);
