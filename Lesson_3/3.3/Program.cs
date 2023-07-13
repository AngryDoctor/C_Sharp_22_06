// Задача 3. Напишите программу, которая принимает на вход число (N) и
// выдает таблицу квадратов числе от 1 до N.

Console.WriteLine("Введите число");
double A1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число произведений в степень");
int N = int.Parse(Console.ReadLine()!);
double result = A1;
int b = 1;

if (N == 0)
{
    Console.WriteLine("значение равно 1");
}
else
    do
    {
        result = result * A1;
        b = b + 1;
        Console.WriteLine("Значения = " + result);
    } while (b <= N);
