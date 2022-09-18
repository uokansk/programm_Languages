//============================================
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
//============================================

int arrayLen = 8;
int[] GenArray(int arrayLen) // вызываем мтод массив
{
    int[] array = new int[arrayLen];
    Random run = new Random();
    for (int i = 0; i < arrayLen; i++)
    {
        array[i] = run.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}


int[] array = GenArray(arrayLen);
PrintArray(array);
