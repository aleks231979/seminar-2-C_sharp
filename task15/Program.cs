﻿// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 8)
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("В неделе 7 дней");
}
