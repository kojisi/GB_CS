/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Чётные числа от 1 до {N}: ");
int i = 2; 
while (i <= N) 
{
    Console.Write(i); 
    i += 2;
    if (i <= N)
    {
        Console.Write(", ");
    }
}