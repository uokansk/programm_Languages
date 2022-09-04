//======================================================
// write a program with an output random number [10, 99]
// and show large digit
//======================================================

// System.Random numberGenerator = new System.Random();

// int number = numberGenerator.Next(10, 100);
// int firstNumber = number / 10;
// int secondNumber = number % 10;

// int max = Math.Max(firstNumber, secondNumber);

// Console.WriteLine(number);
// // Console.WriteLine(max);

// // вариант char
// char[] charArray = number.ToString().ToCharArray();
// Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);


// методы void
void Variant()
{
    Console.WriteLine("метод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    int max = Math.Max(firstNumber, secondNumber);

    Console.WriteLine(number);
    Console.WriteLine(max);
}

void MyChar()
{
    Console.WriteLine("метод 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(number);
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

Variant();
MyChar();