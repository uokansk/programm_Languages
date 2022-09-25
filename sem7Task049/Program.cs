//////////////////////////////////////////////////
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты
//////////////////////////////////////////////

// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вызываем метод заполнения двумерного массив
int[,] Generate2DArray(int row, int colum, int startVal, int finalVal)
{
    int[,] array2D = new int[row, colum];
    Random numSintezator = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array2D[i, j] = numSintezator.Next(startVal, finalVal + 1);
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

int[,] Update2DArr(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr2D.GetLength(1); j+=2)
        {
            arr2D[i,j] = arr2D[i,j] *arr2D[i,j];
        }
    }
    return arr2D;
}


int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(row, colum, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
Print2DArray(Update2DArr(arr2D));