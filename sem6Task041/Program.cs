///////////////////////////////////////////////////////////////+
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
///////////////////////////////////////////////////////////

// ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int Count(int numberM)
{
    int res = 0;
    for (int i = 0; i < numberM; i++)
    {
        int num = ReadData("ввидите число: ");
        if (num > 0)
        {
            res++;
        }
    }
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numberM = ReadData("ввидите количество чисел: ");

PrintResult("чисел больше 0: " + Count(numberM));