//================================================
// Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
//===========================================

int ReadDada(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0"); // считываем число
    return num; // возвращаем значение
}

int CalculateSum(int num)
{
    int sumDigit = 0;
    while (num > 0)
    {
        sumDigit = sumDigit + num % 10;
        num = num / 10;
    }
    return sumDigit;
}


// метод вывода результата
void PrintDate(string line)
{
    Console.WriteLine(line);
}

int number = ReadDada("Введите число ");
int res = CalculateSum(number);
PrintDate("Сумма цифр " + res);
