//////////////////////////////////////
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1
/////////////////////////////////////////////

//введем данные
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string FibNum(int num)
{
    string res = string.Empty;
    int first = 0;
    int last = 1;
    int temp = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + first;
        temp = first + last;
        first = last;
        last = temp;
    }
    return res;
}

// метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// int numb = ReadData("введите число ");
// string line = FibNum(numb);
// PrintResult(line);

PrintResult("числа Фибоначчи " + FibNum(ReadData("введите число ")));
