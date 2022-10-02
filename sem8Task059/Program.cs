/////////////////////////////////////////////////////////
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.
///////////////////////////////////////////////////////


int[,] Generate2DArray(int row, int colum, int startVal, int finalVal)
{
    int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = numSintezator.Next(startVal, finalVal); //  .NextDoubl
        }
    }
    return array2D;
}

// печать двухмерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// int FindMinElement(int[,] arr)
// {
//     int minElement = arr[0, 0];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (minElement > arr[i, j])
//             {
//                 minElement = arr[i, j];
//                 Console.Write($"{arr[i, j] + " " + (i, j)}\t");
//             }
//         }
//     }
//     return minElement;
// }

void FindMinElementV2(int[,] arr, ref int x, ref int y)
{
    int minElement = arr[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minElement > arr[i, j])
            {
                minElement = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreatArray(int[,] arr, int x, int y)
{
    int[,] outArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == x) { }
        else
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y) { }
                else
                {
                    outArray[k, m] = arr[i, j];
                    m++;
                }
            }
            k++;
        }
    }
    return outArray;
}

int[,] arr2D = Generate2DArray(4, 4, 0, 10);
Print2DArray(arr2D);
int x = -1;
int y = -1;
FindMinElementV2(arr2D, ref x, ref y);
// int[,] outArray = CreatArray(arr2D, x, y);

// FindMinElement(arr2D);
Print2DArray(CreatArray(arr2D, x, y));
