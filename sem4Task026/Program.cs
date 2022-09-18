//==========================================
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
//===========================================

// метод ввода данных
int ReadData(string line) // это метод
{
    Console.Write(line); // выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0"); // считываем число
    return number; // возвращаем значение
}

// метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum++;
        num = num / 10;
    }
    return sum;
}

// метод подсчета
int DigitCountLog(int num)
{
    return (int)Math.Log10(num) + 1; //длина числа
}

int DigitCountString(int num)
{
    // int digitCount = a.ToString().Length;
    // return digitCount;
    return (int) num.ToString().Length;
}


int number = ReadData("Enter number ");

DateTime d1 = DateTime.Now;
int res1 = DigitCount(number);
Console.WriteLine(DateTime.Now - d1);
PrintResult("DigitCount " + res1);

DateTime d2 = DateTime.Now;
int res2 = DigitCountLog(number);
Console.WriteLine(DateTime.Now - d2);
PrintResult("DigitCountLog " + res2);

DateTime d3 = DateTime.Now;
int res3 = DigitCountString(number);
Console.WriteLine(DateTime.Now - d3);
PrintResult("DigitCountString " + res3);