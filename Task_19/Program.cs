﻿// // // Задача 19: Напишите программу принимающую 5 значное число и проверяющее является ли оно полиндромом.

// int ReversDigit(int digit)
// {
//     int a1 = digit % 10;
//     int a2 = digit / 10 % 10;
//     int a3 = digit / 100 % 10;
//     int a4 = digit / 1000 % 10;
//     int a5 = digit / 10000 % 10;
//     int result = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
//     return (int) result;
// }

// string Comparison(int numA, int numB)
// {
//     string result = String.Empty;
//     if (numA == numB)
//     {
//         result = ("Число полиндром. ");
//     }
//         else
//     {
//         result = ("Не является полиндромом. ");
//     }
//     return result;
// }

// Console.WriteLine("Введите пятизначное число: ");
// int incomingDigit = Convert.ToInt32(Console.ReadLine());

// int reversDigit = Convert.ToInt32(ReversDigit(incomingDigit));

// string comparison = Comparison(incomingDigit, reversDigit);

// Console.WriteLine(comparison);


/*
Напишите метод, который принимает на вход пятизначное 
число number и проверяет, является ли оно палиндромом.
14212 -> False
12821 -> True
234322 -> Число не пятизначное
*/
using System.ComponentModel;

System.Console.Write("Введи пятизначное число: ");
int userNambr = Convert.ToInt32(Console.ReadLine());

if (userNambr < 9999 || userNambr > 100000)
{
    System.Console.WriteLine("Читай условие!"); // При вводе неверных данный по мимо "Читай условие!" выводится еще и "False"

}
else
{
    int nambr1 = userNambr % 10;
    int nambr2 = userNambr / 10 % 10;
    int nambr3 = userNambr / 100 % 10;
    int nambr4 = userNambr / 1000 % 10;
    int nambr5 = userNambr / 10000 % 10;

    int pcNambr = (nambr1 * 10000) + (nambr2 * 1000) + (nambr3 * 100) + (nambr4 * 10) + nambr5;

    if (userNambr == pcNambr)
    {
        System.Console.WriteLine("True");
    }
    else
    {
        System.Console.WriteLine("False");
    }
}