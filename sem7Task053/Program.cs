//////////////////////////////////////////////////////////
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива
///////////////////////////////////////////////////////////

// вызываем метод заполнения двумерного массив

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Generate2DArray(int[,] array2D, int startVal, int finalVal)
{
    // int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = numSintezator.Next(startVal, finalVal + 1);
        }
    }
    return array2D;
}

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

void Change2DArray(int[,] arr2D)
{
    int temp = 0;
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        temp = arr2D[0, i];
        arr2D[0, i] = arr2D[arr2D.GetLength(0) - 1, i];
        arr2D[arr2D.GetLength(0) - 1, i] = temp;
    }
}

int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");
int[,] array2D = new int[row, colum];

Generate2DArray(array2D, 10, 99);
Print2DArray(array2D);
Console.WriteLine();
Console.WriteLine();
Change2DArray(array2D);
Print2DArray(array2D);
