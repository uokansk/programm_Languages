////////////////////////////////////////////
// задайте значение N и вывиди от 1 до N
/////////////////////////////////////////////


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
    string outLine = LineGenRec(numN - 1) + " " + numN;
    return outLine;
}

int numN = ReadData("введи число: ");
string res = LineGenRec(numN);
PrintResult(res);
