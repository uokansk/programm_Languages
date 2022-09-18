//================================================
// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)      2, 4 -> 16
//================================================

// метод ввода данных
int ReadData(string line) // это метод
{
    Console.Write(line); // выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0"); // считываем число
    return number; // возвращаем значение
}

// метод с циклом
long Pow(int num, int pow)
{
    long numPow = 1;
    for (int i = 0; i < pow; i++)
    {
        numPow = numPow * num;
    }
    return numPow;
}

// метод с Math.Pow(num, pow) считает быстрее
long PowMath(int num, int pow)
{
    long numPow = Convert.ToInt32(Math.Pow(num, pow));
    return numPow;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numA = ReadData("Введите число: ");
int numB = ReadData("Введите степень: ");

DateTime d1 = DateTime.Now;
long res = Pow(numA, numB);
Console.Write("метод с циклом ");
Console.WriteLine(DateTime.Now - d1);
PrintResult(res + " ");

DateTime d2 = DateTime.Now;
long resMath = PowMath(numA, numB);
Console.Write("метод с Math.Pow(x,y) ");
Console.WriteLine( DateTime.Now - d2);
PrintResult(resMath + " ");
