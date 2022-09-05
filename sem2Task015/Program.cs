//==================================================
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//===================================================

Console.WriteLine("введите первое число");
string? inputLine = Console.ReadLine();

if(inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);
        if (inputNumber == 6 || inputNumber == 7)
            {
                Console.WriteLine("выходной");
            }
        else
            {
                Console.WriteLine("будни");
            }
    }
    