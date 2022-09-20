/////////////////////////////////////////////////
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
///////////////////////////////////////////////

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

// метод вывода данных
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

bool FindElement(int element, int[] array)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            res = true;
            break;
        }
    }
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Количество элементов: ");
int startVal = ReadData("Начальное значение: ");
int finalVal = ReadData("Конечное значение: ");
int element = ReadData("Введите искомый элемент: ");

int[] arr = GenerateArray(arrayLength, startVal, finalVal);
PrintArray(arr);

bool res = FindElement(element, arr);
PrintResult(" " + res);