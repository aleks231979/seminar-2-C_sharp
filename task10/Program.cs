﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    number = number % 100;
    number = number / 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Введено не трёхзначное число.");
}
