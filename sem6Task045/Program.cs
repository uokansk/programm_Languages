/////////////////////////////////////////////
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.
////////////////////////////////////////////

// вызываем метод заполнения массив
int[] GenerateArray(int arrLength, int startVal, int finalVal)
{
    int[] array = new int[arrLength];
    Random numSintezator = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = numSintezator.Next(startVal, finalVal + 1);
    }
    return array;
}

// метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

int[] CopyArr(int[] arr)
{
    // int[] productNumArr = new int[arr.Length / 2];
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i];
    }
    return outArr;
}

// метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int[] arr = GenerateArray(10, 1, 50);
PrintResult("массив");
PrintArray(arr);
PrintResult("копия массив");
PrintArray(CopyArr(arr));
PrintResult("копия массив 2");
PrintArray((int[])arr.Clone());