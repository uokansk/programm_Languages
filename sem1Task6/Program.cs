﻿//=====================================
// Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
//=====================================
string? inputLine = Console.ReadLine();
if(inputLine != null)
{   
    int inputNumber = int.Parse(inputLine);
     if (inputNumber % 2 == 0)
    {
        Console.WriteLine("да");      
    }
    else
    { 
        Console.WriteLine("нет");
    }    
}