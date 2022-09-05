//=================================================
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//==================================================

Console.WriteLine("введите число");
string? inputLineA = Console.ReadLine();
if(inputLineA != null && inputLineA.Length >= 3)
    {
        char[] charArray = inputLineA.ToCharArray();
        Console.WriteLine("третья цифра " + charArray[2]);
    }
else
    {
        Console.WriteLine("третьей цифры нет");
    }