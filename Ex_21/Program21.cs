// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// r = sqrt(((x1-x2)^2)+((y1-y2)^2)+((z1-z2)^2)) Какая-то такая формула вроде бы.

Console.WriteLine("Введите координаты первой точки");
Console.Write("X ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Y ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Z ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Y ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Z ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ваши точки А (" + xA + "; " + yA + "; " + zA + ") B (" + xB + "; " + yB + "; " + zB + ")");

double lengthAB = Math.Sqrt(((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB)) + ((zA - zB) * (zA - zB)));
Console.WriteLine("Расстояние между точками = " + lengthAB);

// Как-то нудно, должно быть проще