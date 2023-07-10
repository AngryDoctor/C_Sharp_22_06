//  Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет,
// является ли этот день выходным
Console.Clear();
System.Console.WriteLine();

int day_num = new Random().Next(1, 8);
string[] Days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string txtResult = "";

if (day_num > 5) 
{
    txtResult = $" , это выходной день!";
}
else 
{
    txtResult = $" , это рабочий день ";
}

System.Console.WriteLine();
System.Console.WriteLine($"{day_num} - й день недели - это {Days[day_num - 1]}{txtResult}");
System.Console.WriteLine();

