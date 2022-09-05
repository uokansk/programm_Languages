//==================================================
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//===================================================

// Console.WriteLine("введите число");
// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);
//     if (inputNumber == 6 || inputNumber == 7)
//     {
//         Console.WriteLine("выходной");
//     }
//     else
//     {
//         Console.WriteLine("будни");
//     }
// }
    


// решение с помощью методов

// string inputLine = "";
// int inputNumber = 0;

// void ReadData()
// {
//     Console.WriteLine("введите число");
//     inputLine = Console.ReadLine();
// }

// void CalculateData()
// {
//     if(inputLine != null)
//         {
//             inputNumber = int.Parse(inputLine);
//         }
// }

// void PrintData()
// {
//     if (inputNumber == 6 || inputNumber == 7)
//         {
//             Console.WriteLine("выходной");
//         }
//     else
//         {
//             Console.WriteLine("будни");
//         }
// }

// ReadData();
// CalculateData();
// PrintData();


// решение с помощью Dictionary

Dictionary<int, string> dayWeek = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"}
};

Console.WriteLine("введите число  от 1 до 7");
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 0 && inputNumber <= 7)
    {
        Console.WriteLine(dayWeek[inputNumber]);
    }
    else
    {
        Console.WriteLine("нужно число от 1 до 7");
    }
}
