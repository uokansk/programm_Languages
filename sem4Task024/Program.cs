//==============================================
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
//==============================================

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

// метод подсчета
int variantSimle(int numberN)
{
    int sumNumbers = 0;
    for (int i = 1; i <= numberN; i++)
    {
        sumNumbers += i;
    }    
    return sumNumbers;
}

int variantGaus(int numberN)
{
    int sumNumbers = 0;
    sumNumbers = (numberN * (numberN + 1))/2;
    return sumNumbers;
}

int numberN = ReadData("Enter number ");
DateTime d1 = DateTime.Now;
int res1 = variantSimle(numberN);

DateTime d2 = DateTime.Now;
int res2 = variantGaus(numberN);

PrintResult("summa numbers1 " + res1);
Console.WriteLine(DateTime.Now - d1);
PrintResult("summa numbers2 " + res2);
Console.WriteLine(DateTime.Now - d2);
