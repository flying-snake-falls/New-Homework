// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int DigitTwo(int dig)
{
    int res = (dig / 10) % 10;
    return res;
}

Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());
            

int result = DigitTwo(digit);

Console.WriteLine($"Вторая цифра цисла {digit} : {result} ");
