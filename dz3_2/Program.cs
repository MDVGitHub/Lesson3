/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("введите координаты первой точки");
Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки");
Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceToPoint(double x1, double x2, double y1, double y2, double z1, double z2)

    {         
    return Math.Sqrt ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    }

double Length =  Math.Round (DistanceToPoint(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Расстояние между точками равно {Length} ");