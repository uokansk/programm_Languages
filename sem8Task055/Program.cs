/////////////////////////////////////////////////
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.
/////////////////////////////////////////////////


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация массива
int[,] Generete2DArray(int[,] array2D, int startVal, int finalVal)
{
    // int[,] arr2D = new int[row, column];
    Random numGen = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = numGen.Next(startVal, finalVal);
        }
    }
    return array2D;
}

int[,] Change2DArray(int[,] arr)
{
    int[,] arr2D = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arr2D[i, j] = arr[j, i];
        }
    }
    return arr2D;
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
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] array2D = new int[row, column];

// Generete2DArray(row,column, 1, 10);
Print2DArray(Generete2DArray(array2D, 1, 10));
Console.WriteLine();
Print2DArray(Change2DArray(array2D));
