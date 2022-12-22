// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

Console.Write("Введите Xa: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите Ya: ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите Za: ");
double za = double.Parse(Console.ReadLine());
Console.Write("Введите Xb: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите Yb: ");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите Zb: ");
double zb = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));

Console.WriteLine($"Расстояние между точками A и B равно {d:f5}.");
