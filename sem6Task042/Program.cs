///////////////////////////////////////////////////////////////
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
///////////////////////////////////////////////////////////

// ввод данных
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// string BinConvert(int number)
// {
//     string res = "";
//     while (number > 0)
//     {
//         res = number % 2 + res;
//         number = number / 2;
//     }
//     return res;
// }

// //вывод данных
// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }

// int number = ReadData("введите число ");

// // PrintResult(BinConvert(number).ToString());
// PrintResult("Исходное число в бинарном формате: ", BinConvert(number));


// ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int number = ReadData("введите число ");
string numBin = Convert.ToString(number, 2);

Console.Write($"Число {number} в двоичной системе: {numBin}");