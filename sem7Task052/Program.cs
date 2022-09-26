////////////////////////////////////////////////////
// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
/////////////////////////////////////////////////////

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

double[] Count(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[j] = arr[j] + arr2D[i, j];
        }
    }
    // for (int k = 0; k < arr2D.GetLength(1); k++)
    // {
    //     arr[k] = arr[k] / Convert.ToDouble(arr2D.GetLength(0));
    // }
    return arr;
}

double[] AverageColumn(double[] arr, int[,] arr2D)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = arr[k] / Convert.ToDouble(arr2D.GetLength(0));
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

int[,] arr2D = Generate2DArray(8, 10, 10, 99);
Print2DArray(arr2D);

Console.WriteLine();
PrintArray(Count(arr2D));
Console.WriteLine();
PrintArray(AverageColumn(Count(arr2D), arr2D));
