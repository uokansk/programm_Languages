//=====================================
// на вход 3х значное число на выходе показываает последнюю цифру этого числа
//=====================================

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    // int lastDigital = inputNumber % 10;
    //     Console.Write(lastDigital);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int lastDigital = inputNumber % 10;
        Console.Write(lastDigital);
    }
}