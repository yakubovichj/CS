//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
double GetNumber(string name)
{
    Console.Write("Enter the coordinate {0}: ", name);
    return Convert.ToDouble(Console.ReadLine());
}
double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double z1 = GetNumber("z1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");
double z2 = GetNumber("z2");

Console.WriteLine("Distance between points: {0:f}", GetDistance(x1, y1, z1, x2, y2, z2));