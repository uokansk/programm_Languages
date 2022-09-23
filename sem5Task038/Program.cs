///////////////////////////////////////
// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
///////////////////////////////////////



int startVal = 0; // начало массива
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
        array[i] = numSintezator.Next(startVal, finalVal + 1);  //  .NextDoubl
    }
    return array;
}

// метод минимальный элемент
int MinElement(int[] array)
{
    int minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
        }
    }
    return minElement;
}

// метод максимальный элемент
int MaxElement(int[] array)
{
    int maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

// метод подсчета
int DifferenceMaxMin(int maxElement, int minElement)
{
    return maxElement - minElement;
}

// метод подсчета объедененный с мин макс
int DifferenceMaxMinVariantTwo(int[] array)
{
    int minElement = array[0];       // double Min = int.MaxValue
    int maxElement = array[0];       // double Max = int.MinValue
    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
        }
        if (maxElement < array[i])
        {
            maxElement = array[i];
        }
    }
    return maxElement - minElement;
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

int resMin = MinElement(arr);
PrintResult("Минимальный элемент в массиве: " + resMin);

int resMax = MaxElement(arr);
PrintResult("Максимальный элемент в массиве: " + resMax);

int resDifference = DifferenceMaxMin(resMax, resMin);
PrintResult("Разница элементов: " + resDifference);

int resDifferenceVariantTwo = DifferenceMaxMinVariantTwo(arr);
PrintResult("Разница элементов: " + resDifferenceVariantTwo);
