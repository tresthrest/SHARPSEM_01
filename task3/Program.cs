// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите номер дня недели: ");
// int DayWeek = Convert.ToInt32(Console.ReadLine());

// switch (DayWeek)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Ошибка");
//         break;
// }

System.Console.Write("Введите номер дня недели: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());

if (DayWeek == 1)
    System.Console.WriteLine("Сегодня понедельник");
else if (DayWeek == 2)
    System.Console.WriteLine("Сегодня вторник");
else if (DayWeek == 3)
    System.Console.WriteLine("Сегодня среда");
else if (DayWeek == 4)
    System.Console.WriteLine("Сегодня четверг");
else if (DayWeek == 5)
    System.Console.WriteLine("Сегодня пятница");
else if (DayWeek == 6)
    System.Console.WriteLine("Сегодня суббота");
else if (DayWeek == 7)
    System.Console.WriteLine("Сегодня воскресенье");
else System.Console.WriteLine("Такого дня не существует");