/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

switch (number % 2)
{
    case 0:
        Console.WriteLine($"Число {number} является чётным.");
        break;
    default:
        Console.WriteLine($"Число {number} не является чётным.");
        break;
}