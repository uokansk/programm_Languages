///////////////////////////////////////////////////////////
// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа numM и n.
/////////////////////////////////////////////////////////

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

int FuncAkkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numM > 0 && numN == 0)
    {
        return FuncAkkerman(numM - 1, 1);
    }
    return FuncAkkerman(numM - 1, FuncAkkerman(numM, numN - 1));
}

int numM = ReadData("введи число: ");
int numN = ReadData("введи число: ");
int res = FuncAkkerman(numM, numN);
PrintResult("" + res);
