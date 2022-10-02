/////////////////////////////////////////////
// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
/////////////////////////////////////////////////

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

string LineGenRec(int numN)
{
    if (numN == 0)
        return "";

    // string outLine = numN + " " + LineGenRec(numN - 1);
    string outLine = numN + " " + LineGenRec(numN - 1);
    return outLine;
}

int numN = ReadData("введи число: ");
string res = LineGenRec(numN);
PrintResult(res);
