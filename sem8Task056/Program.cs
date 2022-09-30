////////////////////////////////////////////////////////////////
// Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
//////////////////////////////////////////////////////////////

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

// сумма строк
int[] SummaRow(int[,] arr2D)
{
    int[] arr = new int[arr2D.GetLength(0)];

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[i] = arr[i] + arr2D[i, j];
        }
    }
    return arr;
}

// минимальный элемент
int MinElementRow(int[] arr)
{
    int minElement = arr[0];
    int index = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (minElement > arr[i])
        {
            minElement = arr[i];
            index = i;
        }
    }
    return index;
}

// печать массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine();
}

// метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int row = ReadData("Количество строк: ");
int colum = ReadData("Количество столбцов: ");

int[,] arr2D = Generate2DArray(row, colum, 1, 10);

Print2DArray(arr2D);
Console.WriteLine();
int[] array = SummaRow(arr2D);
PrintArray(array);
Console.WriteLine();

int res = MinElementRow(array);
PrintResult("Строка с наименьшей суммой элементов " + res);
