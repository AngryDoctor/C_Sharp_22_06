﻿// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
// выводит остаток на деление

void rem (int a, int b)
{
    if(a % b == 0)
    Console.WriteLine ("Числа кратные");
    else 
    {
        Console.WriteLine ("Числа не кратные " + a % b);
    }
}
int NumA = int.Parse(Console.ReadLine()!);
int NumB = int.Parse(Console.ReadLine()!);
rem(NumA, NumB);
