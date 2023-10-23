// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number <= 999) //&& двойное условие.
{
   int lastDigit = number%10; //Остаток от деления на 10.
   Console.WriteLine($"Последняя цифра числа {number}, {lastDigit}. ");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}

