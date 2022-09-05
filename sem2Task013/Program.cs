//=================================================
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//==================================================

// Console.WriteLine("введите число");
// string? inputLineA = Console.ReadLine();
// if(inputLineA != null && inputLineA.Length >= 3)
//     {
//         char[] charArray = inputLineA.ToCharArray();
//         Console.WriteLine("третья цифра " + charArray[2]);
//     }
// else
//     {
//         Console.WriteLine("третьей цифры нет");
//     }


string inputLine = "";
char[] charArray = {};

void ReadData()
{
    Console.WriteLine("введите число");
    inputLine = Console.ReadLine();
}

void CalculateData()
{
    if(inputLine != null && inputLine.Length >= 3)
    {
        charArray = inputLine.ToCharArray();        
    }
    
}

void PrintData()
{
    if(charArray[2] != null)
    {
        Console.WriteLine("третья цифра " + charArray[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}

ReadData();
CalculateData();
PrintData();