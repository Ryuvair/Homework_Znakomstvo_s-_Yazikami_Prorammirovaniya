

double Coordinate2DSearch(double arg1_1, double arg1_2, double arg2_1, double arg2_2)
{
double ans = Math.Sqrt( Math.Pow((arg1_1 - arg2_1), 2) + Math.Pow((arg1_2 - arg2_2), 2));
Console.Write("расстояние между точками в 2D пространстве : ");
Console.WriteLine(ans);
return 0;
}


Console.WriteLine("Введите координату А1 ");
double A1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату А2 ");
double A2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B1 ");
double B1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B2 ");
double B2 = double.Parse(Console.ReadLine());

Coordinate2DSearch(A1,A2,B1,B2);