//-------------------------------
// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
int inputNumberA = 0;
bool Result1 = false;
bool Result2 = false;

void ReadData()
{
    Console.WriteLine("введите число");
    string? inputLineA = Console.ReadLine();
    if(inputLineA != null)
    {
        inputNumberA = int.Parse(inputLineA);
    }
}

void CalculetData()
{
    Result1 = (inputNumberA % 7) == 0;
    Result2 = (inputNumberA % 23) == 0;
}

void PrintData()
{
    if (Result1 && Result2)
    {
        Console.WriteLine("число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("не кратно");
    }
}

ReadData();
CalculetData();
PrintData();