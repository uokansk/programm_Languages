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
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// печать одномерного массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// заполнение словаря
int[] FreqDicLoad(int[,] arr)
{
    int[] dic = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i, j]]++;
        }
    }
    return dic;
}

int[,] arr2D = Generate2DArray(3, 5, 0, 10);
Print2DArray(arr2D);
// FreqDicLoad(arr2D);
PrintArray(FreqDicLoad(arr2D));
