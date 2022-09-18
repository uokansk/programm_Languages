//============================================
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N
//=============================================

// метод ввода данных
int ReadData(string line) // это метод
{
    Console.Write(line); // выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0"); // считываем число
    return number; // возвращаем значение
}

// метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// вычисление1
// long MultDigit(int num)
// {
//     long multNumber = 1;
//     int count = 1;
//     while (num >= count)
//     {
//         multNumber = multNumber * count;
//         count++;
//     }
//     return multNumber;
// }

// вычисление2
// long MultDigit(int num)
// {
//     long factorial = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         factorial = factorial * i;
//     }
//     return factorial;
// }

// вычисление3
long MultDigit(int num)
{
    if (num == 1) return 1; 
    return num * MultDigit(num - 1);
}

int number = ReadData("Введите число ");

// DateTime d1 = DateTime.Now;
long res = MultDigit(number);

// Console.WriteLine(DateTime.Now - d1);
PrintResult("Произведение цифр числа " + res);
