////////////////////////////////////////////////////////////
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.
////////////////////////////////////////////////////////


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
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}