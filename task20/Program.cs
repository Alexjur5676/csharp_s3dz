// Напишите программу, которая принимает
//  на вход координаты двух точек и находит 
//  расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по x первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по y первой точки");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по z первой точки");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по x второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по y второй точки");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по z второй точки");
double z2 = Convert.ToInt32(Console.ReadLine());

// √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"{result:f2}");