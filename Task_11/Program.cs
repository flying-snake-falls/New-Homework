// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int FirstLastDigit(int num) // num = number
{
    int firstDigit = (num / 100) * 10;
    int secondDigit = num % 10;
    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    int result = firstDigit + secondDigit;
    return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное двузначное число из диапазона 100 - 999 -> {number} ");

int firstLastDigit = FirstLastDigit(number);
Console.WriteLine($"Первое и последнее число в введенном числе -> {firstLastDigit}");
