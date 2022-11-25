/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("введите координаты первой точки");
Console.Write("Введите координаты x1: ");
int p1x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int p1y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int p1z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки");
Console.Write("Введите координаты x2: ");
int p2x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int p2y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int p2z = Convert.ToInt32(Console.ReadLine());

double DistanceToPoint (double p1x, double p1y, double p1z, double p2x, double p2y, double p2z);

    {
        return  Math.Sqrt((p1x - p2x) * (p1x - p2x) + (p1y - p2y) * (p1y - p2y) + (p1z - p2z) * (p1z - p2z));
    }

double Length =  DistanceToPoint(p1x, p2x, p1y, p2y, p1z, p2z);
Console.WriteLine($"Расстояние между точками равно {Length} ");
