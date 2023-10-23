﻿// double sqrt = Math.Sqrt(5);
// double pow = Math.Pow(3, 5);
// Console.WriteLine(sqrt);
// Console.WriteLine(pow);

//Задача 20: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//double d = 5.09983461; // 5.09
//double dRound = Math.Round(d, 5, MidpointRounding.ToZero);
//Console.WriteLine(dRound);
//Console.WriteLine($"{d:F}");

// double Distance(int x1, int y1, int x2, int y2)
// {
//     int side1 = x1 - x2;
//     int side2 = y1 - y2;
//     double distance = Math.Sqrt(side1 * side1 + side2 * side2);
//     return distance;
// }

// Console.WriteLine("Введите координаты 1 точки");
// Console.Write("X: ");
// int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты 2 точки");
// Console.Write("X: ");
// int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

// double result = Distance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
// double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

// Console.WriteLine(resultRound);

Console.Clear();
System.Console.Write("Задай координату точки A x:");
int userAX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A y:");
int userAY = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки B x:");
int userBX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B y:");
int userBY = int.Parse(Console.ReadLine());

//int sqrX = (userBX - userAX) * (userBX - userAX);
double sqrX = Math.Pow(userBX - userAX, 2); //Math.Pow(а, 2) функция возводит в степень (переменная, в какую степень надо возвести)
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrt = Math.Sqrt(sqrX + sqrY); // Math.Sqrt(sqrX + sqrY) выводит квадратный корень из переменной в скобочках
System.Console.WriteLine(Math.Round(sqrt, 2)); // Math.Round(sqrt, 2) округляет десятичное число (переменная, сколько знаков после запятой оставить)