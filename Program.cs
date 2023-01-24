// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int num = 0;
while (num < number-1)
{
    num += 2;
    Console.Write($"{num} ");
}
