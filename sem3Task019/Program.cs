//=========================================
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//====================================================

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

// сравниваем первую цифру с последней и вторую с предпоследней
bool Polindrom(int number)
{
    if ((number / 10000 == number % 10) && ((number / 1000) % 10) == (number % 100) / 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintResult(string line)
{
    Console.Write(line);
}

// ввести данные
int number = ReadData("Введите 5 значное число: ");

//выводим полученный результат
PrintResult(Polindrom(number).ToString());
