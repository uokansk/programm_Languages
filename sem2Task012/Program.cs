//------------------------------------
// принимает на вход 2 числа и выводит, является ли второе 
// число кратно первому, ели число не кратно первому то 
// выдает остаток от деления
// ----------------------------------------------------

// Console.WriteLine("введите первое число");
// string? inputLineA = Console.ReadLine();
// Console.WriteLine("введите второе число");
// string? inputLineB = Console.ReadLine();
// if(inputLineA != null && inputLineB != null)
// {
//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     bool Result = (inputNumberB % inputNumberA == 0);

//     if (Result)
//     {
//         Console.WriteLine("второе число кратно первому");
//     }
//     else
//     {
//         Console.WriteLine("не кратно " + inputNumberB % inputNumberA);
//     }

//     Console.WriteLine(Result);
// }


// метод с тернальным оператором
// void TernaryOperator()
// {
//     Console.WriteLine("введите первое число");
//     string? inputLineA = Console.ReadLine();
//     Console.WriteLine("введите второе число");
//     string? inputLineB = Console.ReadLine();
//     if(inputLineA != null && inputLineB != null)
//     {
//         int inputNumberA = int.Parse(inputLineA);
//         int inputNumberB = int.Parse(inputLineB);
//         Console.WriteLine((inputNumberB % inputNumberA == 0) ? "второе число кратно первому" : "не кратно " + inputNumberB % inputNumberA);
//     }
// }

// TernaryOperator();


// скелет метода
int inputNumberA = 0;
int inputNumberB = 0;
bool Result = false;
// получаем данные
void ReadData()
{
    Console.WriteLine("введите первое число");
    string? inputLineA = Console.ReadLine();
    Console.WriteLine("введите второе число");
    string? inputLineB = Console.ReadLine();
    if(inputLineA != null && inputLineB != null)
    {
        inputNumberA = int.Parse(inputLineA);
        inputNumberB = int.Parse(inputLineB);        
    }
}

// вычисляем 
void Calvulate()
{
    Result = (inputNumberB % inputNumberA == 0);
}

// выводим результат
void Print()
{
    if (Result)
    {
        Console.WriteLine("второе число кратно первому");
    }
    else
    {
        Console.WriteLine("не кратно " + inputNumberB % inputNumberA);
    }
}

ReadData();
Calvulate();
Print();