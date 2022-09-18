///////////////////////////////////////////////////////
// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
////////////////////////////////////////////////////

// метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вызываем мтод массив
int[] GenArray(int number, int startVal, int finalVal) 
{
    int[] array = new int[number];
    Random run = new Random();
    for (int i = 0; i < number; i++)
    {
        array[i] = run.Next(startVal, finalVal);
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

int num = ReadData("Количество элементов: ");
int num1 = ReadData("Начальное значение: ");
int num2 = ReadData("Конечное значение: ");
int[] array = GenArray(num, num1, num2);
PrintArray(array);
