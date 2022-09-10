//======================================================
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.
//===========================================

// чтенеие данных из консоли
int ReadData(string line) // это метод
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}


// string LineNumbers(int numberN) 
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i + "\t";
//         ++i;        
//     }
//     outLine = outLine + i;

//     return outLine;

// }

// string LineSqer(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i * i + "\t";
//         ++i;        
//     }
//     outLine = outLine + numberN * numberN;

//     return outLine;

// }

string LineNumbers(int numberN, int pow) 
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i,pow) + "\t";
        ++i;        
    }
    outLine = outLine + Math.Pow(i,pow);

    return outLine;

}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число: ");

// string lineTop = LineNumbers(num);
// string lineDown = LineSqer(num);

// string lineTop = LineNumbers(num, 1);
// string lineDown = LineNumbers(num, 2);

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));
