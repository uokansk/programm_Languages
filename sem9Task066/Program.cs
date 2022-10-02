//////////////////////////////////////////////////
// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
/////////////////////////////////////////////////////////////

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

int SummaMN(int numM, int numN)
{
    int temp = 0;
    if (numM > numN)
    {
        temp = numN;
        numN = numM;
        numM = temp;
    }
    if (numM == numN)
        return numN;

    // string outLine = numN + " " + LineGenRec(numN - 1);
    int outLine = numM + SummaMN(numM + 1, numN);
    return outLine;
}

int numM = ReadData("введи число: ");
int numN = ReadData("введи число: ");
int res = SummaMN(numM, numN);
PrintResult("сумма чисел от M до N" + res);
