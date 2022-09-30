//////////////////////////////////////////////////
// Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.
//////////////////////////////////////////////////

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

void SortArray(int[,] arr2D)
{
  for (int i = 0; i < arr2D.GetLength(0); i++)
  {
    // for (int j = 0; j < arr2D.GetLength(1); j++)
    // {
      for (int k = 0; k < arr2D.GetLength(1) - 1; k++)
      {
        if (arr2D[i, k] < arr2D[i, k + 1])
        {
          int temp = arr2D[i, k + 1];
          arr2D[i, k + 1] = arr2D[i, k];
          arr2D[i, k] = temp;
        }
      }
    // }
  }
}

int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(row, colum, 1, 10);

Print2DArray(arr2D);
SortArray(arr2D);
Console.WriteLine("массив отсортирован");
Print2DArray(arr2D);
