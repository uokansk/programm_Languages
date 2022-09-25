////////////////////////////////////////////////////
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
/////////////////////////////////////////////////

// чтение данных
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// вызываем метод заполнения двумерного массив
int[,] Generate2DArray(int row, int colum)
{
    int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = i + j;
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

// int row = ReadData("Количество строк: ");
// int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(3, 4);
Print2DArray(arr2D);