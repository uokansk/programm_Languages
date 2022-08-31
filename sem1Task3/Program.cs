//=====================================
// выдать название дня недели по заданному номеру
//=====================================

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputDayOfWeek =int.Parse(inputLine);
    
    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "Понедельник";
    // dayOfWeek[1] = "Вторник";
    // dayOfWeek[2] = "Среда";
    // dayOfWeek[3] = "Четверг";
    // dayOfWeek[4] = "Пятница";
    // dayOfWeek[5] = "Суббота";
    // dayOfWeek[6] = "Воскресенье";
    // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    // {
    //     Console.WriteLine("Такого дня нет");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    // }
    // string outDayOfWeek = string.Empty;

    // switch (inputDayOfWeek)
    // {
    //     case 1: outDayOfWeek = "Monday"; break;
    //     case 2: outDayOfWeek = "Tuesday"; break;
    //     case 3: outDayOfWeek = "Wednesday"; break;
    //     case 4: outDayOfWeek = "Thursday"; break;
    //     case 5: outDayOfWeek = "Friday"; break;
    //     case 6: outDayOfWeek = "Saturday"; break;
    //     case 7: outDayOfWeek = "Sunday"; break;

    //     default: outDayOfWeek = "there is no such day"; break;
    // }
    // Console.WriteLine(outDayOfWeek);

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.getDayName((DayOfWeek)Enum.GetValues(typof(DayOfWeek)).GetValue(inputDayOfWeek));
    
    
    Console.WriteLine(outDayOfWeek);



}