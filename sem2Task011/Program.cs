//======================================================
// вывести 3х значное число, удалить вторую цифру этого числа
//======================================================!");

// System.Random numberGenerator = new System.Random();
// int number = numberGenerator.Next(100, 1000);

// Console.WriteLine(number);

// int withoutSekondDigit = (number / 100) * 10 + number % 10;

// Console.WriteLine(withoutSekondDigit);

// // вариант 2
// char[] charArray = number.ToString().ToCharArray();
// Console.WriteLine(charArray);
// Console.WriteLine(charArray[0]);
// Console.WriteLine(charArray[2]);
// Console.WriteLine("" + charArray[0] + charArray[2]);
// Console.WriteLine(charArray[0] + charArray[2]);


// метод
void withoutSekondDigit()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    int withoutSekondDigit = (number / 100) * 10 + number % 10;
    Console.WriteLine(withoutSekondDigit);
}

withoutSekondDigit();