////////////////////////////////////////////////
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
//////////////////////////////////////////////

int arrLength = 123; // Длина массива
int startVal = -100; // начало массива
int finalVal = 100; // конец массива

// чтение данных
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

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

// метод количества положительных чисел
int CountElement(int[] array)
{
    int countElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99))
        {
            countElement++;
        }
    }
    return countElement;
}

// метод вывода массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// int startVal = ReadData("Начальное значение: ");
// int finalVal = ReadData("Конечное значение: ");

int[] arr = GenerateArray(arrLength, startVal, finalVal);
PrintArray(arr);

int res = CountElement(arr);
PrintResult("количество элементов в отрезке [10,99]: " + res);

PrintResult("в массиве " + CountElement(arr) + " количество элементов в отрезке [10,99]");
