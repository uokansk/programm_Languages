/////////////////////////////////////////
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
////////////////////////////////////////

// int startVal = -100; // начало массива
// int finalVal = 100; // конец массива
// int row = 3;
// int colum = 4;

// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вызываем метод заполнения двумерного массив
int[,] Generate2DArray(int row, int colum, int startVal, int finalVal)
{
    int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = numSintezator.Next(startVal, finalVal + 1); //  .NextDoubl
        }
    }
    return array2D;
}

// // Печать двумерного массива
// void Print2DArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }


ConsoleColor[] myColor = new ConsoleColor[]
{
    ConsoleColor.Cyan,
    ConsoleColor.Blue,
    ConsoleColor.Green,
    ConsoleColor.Gray,
    ConsoleColor.Magenta,
    ConsoleColor.Red,
    ConsoleColor.Yellow
};

// Печать двумерного массива wdtnjv
void Print2DArrayColor(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = myColor[new System.Random().Next(0,6)];
            Console.Write($" {arr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// метод вывода данных
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(row, colum, 10, 99);
Print2DArrayColor(arr2D);
