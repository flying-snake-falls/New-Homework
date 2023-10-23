// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 5 ->
// // 1 | 1
// // 2 | 8
// // 3 | 27
// // 4 | 64
// // 5 | 125

// void NumberInCube(int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         Console.WriteLine($"{count, 3} -> {count*count*count, 5}");
//         count++;
//     }
// }

// Console.WriteLine("Введите натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// NumberInCube(number);

using System;

public class Answer
{
   static void ShowCube(int N)
    {
        int count = 1;
        while(count <= N)
        {
            Console.WriteLine($"N = {N}");
            Console.WriteLine($"N = {N}");
        Console.WriteLine($"{count, 3} -> {count*count*count, 5}");
        count++;
        }
}
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}