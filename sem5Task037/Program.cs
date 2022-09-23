////////////////////////////////////////////
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
///////////////////////////////////////////


// // чтение данных
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

int[] ProductNumArr(int[] arr)
{
    int[] productNumArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        productNumArr[i] = arr[i] * arr[arr.Length - (1 + i)];
    }
    return productNumArr;
}

// метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+ "]");
    Console.WriteLine();
}


// метод вывода результата
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int arrLength = ReadData("Количество элементов: ");
// int startVal = ReadData("Начальное значение: ");
// int finalVal = ReadData("Конечное значение: ");

int[] arr = GenerateArray(50, 1, 1000);

PrintArray(arr);

// int[] arr = GenerateArray(arrayLength, startVal, finalVal);
// PrintArray(arr);
// PrintResult(ProductNumArr(array));
PrintArray(ProductNumArr(arr));