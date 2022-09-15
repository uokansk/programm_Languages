//=======================================================
// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
//========================================

// Console.WriteLine("введите трехзначное число");
// string? inputLineA = Console.ReadLine();
// if(inputLineA != null && inputLineA.Length == 3)
//     {
//         char[] charArray = inputLineA.ToCharArray();
//         Console.WriteLine(charArray[1]);
//     }
// else
//     {
//         Console.WriteLine("введено не трехзначное число");
//     }


// вариант с методами
char Result = ' ';
string inputLineA = " ";

void RaedData()
{
    Console.WriteLine("введите трехзначное число");
    inputLineA = Console.ReadLine();
    // Console.WriteLine("получил" + );
}

void CalculateData()
{
    if (inputLineA != null && inputLineA.Length == 3)
    {
        char[] charArray = inputLineA.ToCharArray();
        Result = charArray[1];
    }
}

void PrintData()
{
    if (inputLineA.Length == 3)
    {
        Console.WriteLine(Result);
    }
    else
    {
        Console.WriteLine("введено не трехзначное число");
    }
}

RaedData();
CalculateData();
PrintData();
