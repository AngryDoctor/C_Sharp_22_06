// Напишите программу, которая выводит случайное трехкратное число и
// удаляет вторую цифру этого числа

Console.Clear();
System.Console.WriteLine("");
int num = new Random().Next(100, 1000);

System.Console.WriteLine($"Второй цифрой числа {num} является {num / 10 % 10} ");

System.Console.WriteLine();


