//=====================================
// введите число N, а на выходе все чмсла от -N до N
//=====================================

string? inputLineN = Console.ReadLine();

if(inputLineN != null)
{
    int inputNumberN =int.Parse(inputLineN);    
    if (inputNumberN > 0)
    {
        int startNumber = (-1) * inputNumberN;
        while (startNumber < inputNumberN)
        {
            Console.Write(startNumber+",  ");
            startNumber++;
        }
        Console.Write(inputNumberN);
    }

}