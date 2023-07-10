// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа.

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int th_num = new Random().Next(100, 1000);
int result = TakeNum(th_num);
Console.WriteLine(result);


// 123 % 10 -> 3
// 123 % 100 -> 23
// 123 % 1000 -> 123

// 123 / 10 -> 12
// 123 / 100 -> 1