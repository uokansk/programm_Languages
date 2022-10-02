///////////////////////////////
// возвести число  А в степень В
///////////////////////////////

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

int RecPow(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    return A * RecPow(A, B - 1);
}

int A = ReadData("введи число A: ");
int B = ReadData("введи число B: ");

int sum = RecPow(A, B);
PrintResult("А в степени В = " + sum);
