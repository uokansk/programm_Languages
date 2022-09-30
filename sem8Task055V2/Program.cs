/////////////////////////////////////////////////
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.
/////////////////////////////////////////////////

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

bool TestRot(int row, int colum)
{
    if (row == colum)
        return true;
    else
        return false;
}

int[,] Rotate2DArray(int[,] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            buf = arr[j, i];
            arr[j, i] = arr[i, j];
            arr[i, j] = buf;
        }
    }

    return arr;
}

int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(row, colum, 1, 10);

Print2DArray(arr2D);

if (TestRot(row, colum))
{
    int[,] matChang = Rotate2DArray(arr2D);
    Print2DArray(matChang);
}
else
    Console.WriteLine("нельзя");
