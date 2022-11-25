/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int n1 = Number / 10000;
int n2 = Number / 1000 % 10;
int n3 = Number / 10 % 10;
int n4 = Number % 10;

if (n1 == n4 && n2 == n3)
{
    Console.WriteLine($"Число {Number} является палиандром");
}
else
{
    Console.WriteLine($"Число {Number} не является палиандром");
}
Console.WriteLine();