//////////////////////////////////////////////////
// Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
//////////////////////////////////////////////////

// вызываем метод заполнения двумерного массив
double[,] Generate2DArray(int row, int colum, int startVal, int finalVal)
{
    double[,] array2D = new double[row, colum];
    Random numGen = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = numGen.Next(startVal, finalVal) + Math.Round(numGen.NextDouble(),2);
        }
    }
    return array2D;
}

// красим
ConsoleColor[] myColor = new ConsoleColor[]
{
    ConsoleColor.Cyan,
    ConsoleColor.Blue,
    ConsoleColor.Green,
    ConsoleColor.Gray,
    ConsoleColor.Magenta,
    ConsoleColor.Red,
    ConsoleColor.Yellow,
    ConsoleColor.DarkCyan,
    ConsoleColor.DarkBlue,
    ConsoleColor.DarkGreen,
    ConsoleColor.DarkGray,
    ConsoleColor.DarkMagenta,
    ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow,
    ConsoleColor.White
};

// Печать двумерного массива цветом
void Print2DArrayColor(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = myColor[new System.Random().Next(0, 15)];
            Console.Write($"{arr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

double[,] arr2D = Generate2DArray(10, 10, 10, 99);
Print2DArrayColor(arr2D);
