//=======================================================================
// # 3 Напишите программу, которая ,
// выдавать название дня недели по заданному номеру
//=======================================================================
string?inputLine = Console.ReadLine();
{
    int inputDayOfWeek = int.Parse(inputLine);
string outDayOfWeek = string.Empty;//""

switch (inputDayOfWeek)
{
    case 1: outDayOfWeek = "понедельник"; break;
    case 2: outDayOfWeek = "вторник"; break;
    case 3: outDayOfWeek = "среда"; break;
    case 4: outDayOfWeek = "четверг"; break;
    case 5: outDayOfWeek = "пятница"; break;
    case 6: outDayOfWeek = "суббота"; break;
    case 7: outDayOfWeek = "воскресенье"; break;
    default: outDayOfWeek = "такого дня нет"; break;
}
Console.WriteLine(outDayOfWeek);
}