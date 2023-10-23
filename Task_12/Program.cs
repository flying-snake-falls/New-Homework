// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int MultiplicityMatching(int numA, int numB)
{
    return numA % numB;
}

Console.WriteLine("Введите число для проверкри на кратность: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число проверяющее кратность: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int multiplicityMatching = MultiplicityMatching(numberA, numberB);
if (multiplicityMatching == 0) Console.Write($"Число {numberA} кратно числу {numberB}. ");
else Console.Write($"Число {numberA} не кратно числу {numberB}, остаток {multiplicityMatching} ");

