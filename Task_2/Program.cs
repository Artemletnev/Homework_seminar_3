// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter firts dot x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter firts dot y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter firts dot z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second dot x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second dot y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second dot z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Distance is: {distance} ");