// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");

int weekDay = Convert.ToInt32(Console.ReadLine());
int day1 = 1;
int day2 = 2;
int day3 = 3;
int day4 = 4;
int day5 = 5;
int day6 = 6;
int day7 = 7;

if (weekDay == day1) Console.WriteLine("Понедельник.");
if (weekDay == day2) Console.WriteLine("Вторник.");
if (weekDay == day3) Console.WriteLine("Среда.");
if (weekDay == day4) Console.WriteLine("Четверг.");
if (weekDay == day5) Console.WriteLine("Пятница.");
if (weekDay == day6) Console.WriteLine("Суббота.");
if (weekDay == day7) Console.WriteLine("Воскресенье.");
else Console.WriteLine("Введено неверный номер.");
