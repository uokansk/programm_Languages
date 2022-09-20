/////////////////////////////
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.
/////////////////////////////

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вызываем метод заполнения массив
int[] FillArray(int number, int startVal, int finalVal)
{
    int[] array = new int[number];
    Random numSintezator = new Random();
    if (startVal < finalVal)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = numSintezator.Next(startVal, finalVal + 1);
        }
    }
    return array;
}

// метод вывода данных
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// вычисляем суммы отрицательных и положительных элементов массива
int[] NegotivPositivSums(int[] array)
{
    int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sums[0] += array[i];
        }
        else
        {
            sums[1] += array[i];
        }
    }
    return sums;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Количество элементов: ");
int startVal = ReadData("Начальное значение: ");
int finalVal = ReadData("Конечное значение: ");

int[] inputArray = FillArray(arrayLength, startVal, finalVal);
PrintArray(inputArray);

int[] sumArray = NegotivPositivSums(inputArray);

PrintResult("сумма > 0: " + sumArray[0] + "; сумма < 0: " + sumArray[1]);
PrintArray(sumArray);
