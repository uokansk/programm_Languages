//////////////////////////////////////////////////////////
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника
///////////////////////////////////////////////

// ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вычисляем факториал
int Factorial(int amountRow)
{
    int x = 1;
    for (int i = 1; i <= amountRow; i++)
    {
        x *= i;
    }
    return x;
}



int amountRow = ReadData("Количество строк: ");

for (int i = 0; i < amountRow; i++)
{
    for (int c = 0; c <= (amountRow - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write(" ");
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}
Console.ReadLine();
