//=====================================
// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
//=====================================
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    // =====================================
    // 1 вариант
    // Console.WriteLine("максимальное число " + Math.Max(inputNumberA, Math.Max(inputNumberB, inputNumberC)));

    // =====================================
    // 2 вариант
    int max = inputNumberA;
    if (max < inputNumberB)
    {
        max = inputNumberB;
    }
    if (max < inputNumberC)
    {
        max = inputNumberC;
    }
    Console.WriteLine("максимальное число " + max);
}
