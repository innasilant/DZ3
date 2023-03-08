/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

Console.WriteLine("Введите координату X первой точки");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
double Z2 = Convert.ToDouble(Console.ReadLine());

double lengthX = Math.Pow(X2 - X1, 2);
double lengthY = Math.Pow(Y2 - Y1, 2);
double lengthZ = Math.Pow(Z2 - Z1, 2);
double length = Math.Round (Math.Sqrt(lengthX + lengthY + lengthZ), 2);
Console.WriteLine("Расстояние между точками: " + length);