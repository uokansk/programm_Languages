/////////////////////////////////////////////////////////
// Напишите программу, которая заполнит спирально массив 4 на 4.
// 
///////////////////////////////////////////////////////

// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация массива
int[,] Generate2DArray(int row, int column)
{
    int[,] array2D = new int[row, column];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array2D.GetLength(0) * array2D.GetLength(1))
    {
        array2D[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array2D.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array2D.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array2D.GetLength(1) - 1)
            j--;
        else
            i--;
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

int row = ReadData("введите размерность массива: ");
int column = row;
int[,] array = Generate2DArray(row, column);
Print2DArray(array);
