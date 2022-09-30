////////////////////////////////////////////////////////////
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
///////////////////////////////////////////////////////////


// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация массива
int[,,] Generate3DArray(int sizeFirst, int sizeSecond, int sizeThird, int startVal, int finalVal)
{
    int[,,] array3D = new int[sizeFirst, sizeSecond, sizeThird];
    Random numSintezator = new Random();

    for (int i = 0; i < sizeFirst; i++)
    {
        for (int j = 0; j < sizeSecond; j++)
        {
            for (int k = 0; k < sizeThird; k++)
            {
                array3D[i, j, k] = numSintezator.Next(startVal, finalVal);
            }
        }
    }
    return array3D;
}

// печать трехмерного массива
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k] + " " + (i, j, k)}\t");
                // Console.Write($"{(i, j, k)}\t");
                // Console.Write("arr[{i}, {j}, {k}]" , i, j, k);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int sizeFirst = ReadData("первые размер: ");
int sizeSecond = ReadData("второй размер: ");
int sizeThird = ReadData("третий размер: ");

int[,,] arr3DArray = Generate3DArray(sizeFirst, sizeSecond, sizeThird, 10, 99);
Print3DArray(arr3DArray);
