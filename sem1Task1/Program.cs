﻿//=====================================
// ввести 2 числа и проверить является ли первое число квадратом второго
//=====================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if(inputLineA != null && inputLineB != null)
{
    int inputNumberA =int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //bool outResult = (inputNumberA * inputNumberA == inputNumberB);
    //bool outResult = (inputNumberB / inputNumberA == inputNumberA);
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

    Console.WriteLine(outResult);
}