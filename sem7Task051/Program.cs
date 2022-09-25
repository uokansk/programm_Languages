///////////////////////////////////////////////////
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.
//////////////////////////////////////////////

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
            array2D[i, j] = numSintezator.Next(startVal, finalVal + 1);
        }
    }
    return array2D;
}

// Печать двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// int SumDiagonal(int[,] arr2D)
// {
//     int summaDiagonal = 0;
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 summaDiagonal = summaDiagonal + arr2D[i,j];
//             }
//         }
//     }
//     return summaDiagonal;
// }

int SumDiagonalVariant2(int[,] arr2D)
{
    int summaDiagonal = 0;
    int len = arr2D.GetLength(0) > arr2D.GetLength(1) ? (arr2D.GetLength(1)) : (arr2D.GetLength(0));

    for (int i = 0; i < len; i++)
    {
        summaDiagonal += arr2D[i, i];
    }
    return summaDiagonal;
}

// метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(row, colum, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
PrintResult("" + SumDiagonalVariant2(arr2D));
