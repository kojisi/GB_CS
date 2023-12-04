﻿/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 & number < 1000)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа: {lastDigit}");
}
else
{
    Console.WriteLine($"Число не является трехзначным");
}