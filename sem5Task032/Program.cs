//////////////////////////////////////
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
////////////////////////////////////////

// чтение данных
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // вызываем метод заполнения массив
// int[] FillArray(int arrLength, int startVal, int finalVal)
// {
//     int[] array = new int[arrLength];
//     Random numSintezator = new Random();

//     for (int i = 0; i < arrLength; i++)
//     {
//         array[i] = numSintezator.Next(startVal, finalVal + 1);
//     }
//     return array;
// }

// // метод вывода данных
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
// }


// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int[] InverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     }
//     return array;
// }

// int arrayLength = ReadData("Количество элементов: ");
// int startVal = ReadData("Начальное значение: ");
// int finalVal = ReadData("Конечное значение: ");

// int[] inputArray = FillArray(arrayLength, startVal, finalVal);
// PrintArray(inputArray);

// int[] sumArray = InverseArray(inputArray);

// // PrintResult("сумма > 0: " + sumArray[0] + "; сумма < 0: " + sumArray[1]);
// PrintArray(sumArray);



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

int[] InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

// Печать массива
void PrintArray(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}


int arrayLength = ReadData("Количество элементов: ");
int startVal = ReadData("Начальное значение: ");
int finalVal = ReadData("Конечное значение: ");

int[] arr = GenerateArray(arrayLength, startVal, finalVal);
PrintArray(arr);

int[] res = InverseArray(arr);
PrintArray(res);