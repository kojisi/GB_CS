/*Задача 11: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Random random = new Random();
int threeDigitNumber = random.Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {threeDigitNumber}");

int firstDigit = (threeDigitNumber / 100);
int lastDigit = (threeDigitNumber % 10);
Console.WriteLine($"Результат: {firstDigit}{lastDigit}");