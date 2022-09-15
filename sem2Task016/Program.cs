//======================================
// Напишите программу, которая принимает
// на вход 2 числа и проверяет, является
// одно число квадратом другого
//=====================================

// чтенеие данных из консоли
int ReadData(string line) // это метод
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine()?? "0");
    // возвращаем значение
    return number;
}

//тест на квадрат
bool SqrTest(int firstNumber, int secondNumber) // это метод
{
    if (firstNumber == secondNumber * secondNumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int firstNumber, int secondNumber)
{
    if (SqrTest(firstNumber, secondNumber))
    {
        Console.WriteLine("число " + firstNumber + " квадрат числа " + secondNumber);
    }
    else
    {
        Console.WriteLine("число " + firstNumber + " не квадрат числа " + secondNumber);
    }
}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");

PrintData(num1, num2);
PrintData(num2, num1);
