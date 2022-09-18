//=========================================
// Напишите программу, которая принимает на вход число
// и проверяет, является ли оно палиндромом.
//====================================================

// чтенеие данных из консоли
// int ReadData(string line) // это метод
// {
//     // выводим сообщение
//     Console.WriteLine(line);
//     // считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // возвращаем значение
//     return number;
// }

// сравниваем первую цифру с последней и вторую с предпоследней
// bool Polindrom(int number)
// {
//     int[] array = number.ToArray();
//     if ((number / 10000 == number % 10) && ((number / 1000) % 10) == (number % 100) / 10)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// void PrintResult(string line)
// {
//     Console.Write(line);
// }

// // ввести данные
// int number = ReadData("Введите 5 значное число: ");

// //выводим полученный результат
// PrintResult(Polindrom(number).ToString());

//ввести число

// int number = ReadData("Введите число: ");
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    long inputNumber = long.Parse(inputLine);
    // int digitCount = (int)Math.Log10(inputNumber) + 1; //длина числа
    long digitCount = inputLine.Length;  //длина числа
    // char[] array = inputNumber.ToString().Reverse().ToArray();
    long reversArray = long.Parse(inputNumber.ToString().Reverse().ToArray());
    if (reversArray == inputNumber)
    {
        // return true;
        Console.WriteLine("true");
    }
    else
    {
        // return false;
        Console.WriteLine("false");
    }

    
    Console.WriteLine(digitCount);
    Console.WriteLine(reversArray);
}

DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);

// string s = Console.ReadLine();

// char[] dig_mas = new char[s.Length];
// for (int i = 0; i < s.Length; i++)
// {
//     dig_mas[i] = s[i];
//     Console.WriteLine(dig_mas[i]);
// }
// Console.ReadLine();
