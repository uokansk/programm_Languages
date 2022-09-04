//=====================================
// Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
//=====================================
string? inputLine = Console.ReadLine();
if(inputLine != null)
{   
    int inputNumber = int.Parse(inputLine);
    int number = 2;
    while (number <= inputNumber)
    {
        if (number % 2 == 0)
        {
            Console.Write(number+ ", ");            
        }
        number++;        
    }       
}