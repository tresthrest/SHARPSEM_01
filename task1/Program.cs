﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (Число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: "); // Вывод в терминал приглашения пользователя ко вводу
// int number = Convert.ToInt32(Console.ReadLine()); // Чтение целого числа из терминала
int number = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine()); // Второй способ конвертации

int result = number * number;
Console.Write("Квадрат введенного числа: ");
Console.WriteLine(result);