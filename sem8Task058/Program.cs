////////////////////////////////////////////////////////////////
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
//////////////////////////////////////////////////////////////

// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация массива
int[,] Generate2DArray(int row, int colum, int startVal, int finalVal)
{
    int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = numSintezator.Next(startVal, finalVal);
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
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// произведение массивов
int[,] MultiplicationArrays(int[,] arr2DFirst, int[,] arr2DSecond)
{
    int[,] array2D = new int[arr2DFirst.GetLength(0), arr2DSecond.GetLength(1)];
    for (int i = 0; i < arr2DFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arr2DSecond.GetLength(1); j++)
        {
            for (int k = 0; k < arr2DSecond.GetLength(0); k++)
            {
                array2D[i, j] = arr2DFirst[i, k] * arr2DSecond[k, j];
            }
        }
    }
    return array2D;
}

int row1 = ReadData("Количество строк 1 массива: ");
int column1 = ReadData("Количество столбцов 1 массива: ");

int row2 = column1;
int column2 = ReadData("Количество столбцов 2 массива: ");

int[,] arr2DFirst = Generate2DArray(row1, column1, 1, 10);
int[,] arr2DSecond = Generate2DArray(row2, column2, 1, 10);

Console.WriteLine("первый массив");
Print2DArray(arr2DFirst);

Console.WriteLine("второй массив");
Print2DArray(arr2DSecond);
int[,] array = MultiplicationArrays(arr2DFirst, arr2DSecond);
Console.WriteLine("произведение массивов");
Print2DArray(array);