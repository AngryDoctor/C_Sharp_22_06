﻿// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа


// Вариант 1

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 10  % 10;
}

int th_num = new Random().Next(100, 1000);
int result = TakeNum(th_num);
Console.WriteLine(result);