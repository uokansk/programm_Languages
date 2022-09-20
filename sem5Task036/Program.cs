////////////////////////////////////
// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
/////////////////////////////////////


int startVal = -100; // начало массива
int finalVal = 100; // конец массива

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
int SumOddElement(int[] array)
{
    int sumOddElement = 0;
    for (int i = 1; i < array.Length; i = i + 2)  // подскажите как это i = i + 2 записать короче
    {
        sumOddElement = sumOddElement + array[i];
    }
    return sumOddElement;
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

int res = SumOddElement(arr);
PrintResult("Сумма нечетных элементов в массиве: " + res);
