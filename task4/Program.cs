﻿// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// Console.Write("Введите число :");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = 0;
// if (numberA > 0) {numberB = -numberA; }
// else {
//         numberB = numberA;
//         numberA= -numberA; 
// }
// while (numberA >= numberB)
// {
//     Console.Write(numberB + " ");
//     numberB++;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = num; i > -num; i--)
// {
//     Console.Write($"{i}, ");
// }
// Console.Write(-num);

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;
if (numberA > 0) {numberB = -numberA; }
else {
        numberB = numberA;
        numberA= -numberA; 
}
while (numberA >= numberB)
{
    Console.Write(numberB + " ");
    numberB++;
}