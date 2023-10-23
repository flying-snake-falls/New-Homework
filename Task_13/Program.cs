// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThreeGigitNumber(int dig)
{
    int result = dig;
    while (dig > 999)
    {
        dig = dig / 10;
    }
    return result = (dig % 10);
}

Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());


int result = ThreeGigitNumber(digit);

Console.WriteLine($"{digit} : {result} ");

