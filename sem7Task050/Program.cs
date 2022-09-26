///////////////////////////////////////////////////////
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
/////////////////////////////////////////////////////////

// вызываем метод заполнения двумерного массив
int[,] Generate2DArray(int row, int colum, int startVal, int finalVal)
{
    int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = numSintezator.Next(startVal, finalVal + 1); //  .NextDoubl
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
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// ищем элемент
int FindElement(int x, int y, int[,] arr)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        return arr[x, y];
    }
    return -1;
}

// метод вывода данных
void PrintResult(int num)
{
    if (num > 0) Console.WriteLine("найденный элемент = " + num);
    else Console.WriteLine("такого элемента нет");
}

int[,] arr2D = Generate2DArray(5, 10, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
int element = FindElement(1, 2, arr2D);
PrintResult(element);
