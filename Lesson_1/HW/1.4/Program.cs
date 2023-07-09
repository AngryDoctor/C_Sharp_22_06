// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int count = 1;
bool not = true;

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Четные числа от 1 до " + num);
while (count <= num)
{
    if (count % 2 != 1)
    {
        Console.Write(count + ", ");
        not = false;
    }
    count++;
}
if (not)
{
    Console.WriteLine("Нет четных чисел");
}
