//////////////////
// пинимать число N и выдавать сумму цифр
///////////////////////


// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumDigit(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return num % 10 + SumDigit(num / 10);
}

int numN = ReadData("введи число: ");
int sum = SumDigit(numN);
PrintResult("сумма цифр в числе = " + sum);
