
// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (без пеобразования типов)
// int Digits(int num)
// {
//     int ed = num % 100;
//     int dec = ed / 10;
//     int result;
//     if (dec > 9)
//     {
//         result = dec / 10;
//     }
//     else result = dec;
//     return result;
// }
// Console.WriteLine("Введите трехзначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x > 99 && x < 999)
// {
//     Console.Write($"Вторая цифра этого числа - {Digits(x)}");
// }
// else
// {
// Console.Write("Это не трехзначное число. Введите, пожалуйста, трехзначное число.");
// }

// //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (без пеобразования типов)
// int Digits(int num)
// {
//     int ed = num % 10;
//     // int dec = ed / 10;
//     // int result;
//     // if (ed > 9)
//     // {
//     //     result = dec / 10;
//     // }
//     // else result = dec;
//     return ed;
// }
// Console.WriteLine("Введите трехзначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x > 99 && x < 999)
// {
//     Console.Write($"Третья цифра этого числа - {Digits(x)}");
// }
// else
// {
// Console.Write("Это не трехзначное число. Введите, пожалуйста, трехзначное число.");
// }

// //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Является ли указанный день выходным?");
// Console.Write("Введите цифру, обозначающую день недели ");
// int DayNum = Convert.ToInt32(Console.ReadLine());
// void DaysWeek(int num)
// {
//     if (num == 6 || num == 7)
//     {
//         Console.Write(DayNum + " - да");
//     }
//     else if (num < 1 || num > 7)
//     {
//         Console.WriteLine("нет такого дня недели");
//     }
//     else Console.Write(DayNum + " - нет");
// }
// DaysWeek(DayNum);