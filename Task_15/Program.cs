// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string CheckingForADayOff(int day)
{
    if(day == 1) return ("Не выходной.");
    if(day == 2) return ("Не выходной.");
    if(day == 3) return ("Не выходной.");
    if(day == 4) return ("Не выходной.");
    if(day == 5) return ("Не выходной.");
    if(day == 6) return ("Выходной.");
    if(day == 7) return ("Выходной.");
    else return ("Не корректный ввод.");
}
Console.WriteLine("Введите день недели для проверки: ");
int weekday = Convert.ToInt32(Console.ReadLine());

string result = CheckingForADayOff(weekday);
Console.WriteLine(result);