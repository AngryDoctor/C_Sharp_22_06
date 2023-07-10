// Напишите программу, которая выаодит треью цифру заданного числа или сообщает,
// что третьей цифры нет

System.Console.WriteLine();

int num = new Random().Next(1, 1500);
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {num}");
if (num / 100 > 0)
{
    System.Console.WriteLine($"Третьей цифрой числа {num} является цифра {num / 100 % 10}");
}
else 
{
    System.Console.WriteLine($"У числа {num} нет третьей цифры");
}
System.Console.WriteLine();

