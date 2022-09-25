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

int numb = ReadData("введите число ");
string numBin = Convert.ToString(numb, 2);

Console.WriteLine($"Число {numb} в двоичной системе: {numBin}");

 numBin = Convert.ToString(numb, 8);
Console.WriteLine($"Число {numb} в восьмеричной системе: {numBin}");

 numBin = Convert.ToString(numb, 16);
Console.WriteLine($"Число {numb} в шестнадцатеричной системе: {numBin}");