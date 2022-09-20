///////////////////////////////////
// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.
//////////////////////////////////////


int startVal = 100;  // начало массива
int finalVal = 1000; // конец массива

// чтение данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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
int CountPositivNumbers(int[] array)
{
    int countPositiv = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i] % 2 == 0)
        {
            countPositiv++;
        }
    }
    return countPositiv;
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

int arrayLength = ReadData("Длина массива: ");

int[] arr = GenerateArray(arrayLength, startVal, finalVal);
PrintArray(arr);

int res = CountPositivNumbers(arr);
PrintResult("Количество положительных чисел в массиве: " + res);
