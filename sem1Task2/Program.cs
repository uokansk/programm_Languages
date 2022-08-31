//=====================================
// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число 
// большее, а какое меньшее.
//=====================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if(inputLineA != null && inputLineB != null)
{   
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //=====================================
    // Первый вариант

    Console.WriteLine("минимальное число " + Math.Min(inputNumberA, inputNumberB));
    Console.WriteLine("максимальное число " + Math.Max(inputNumberA, inputNumberB));

    //=====================================
    // Второй вариант
        
    if (inputNumberA < inputNumberB)
    {
        Console.WriteLine("Число " + inputNumberA + " меньше числа " + inputNumberB); 
    }
    else
    {
        Console.WriteLine("Число " + inputNumberB + " меньше числа " + inputNumberA);
    }  
}