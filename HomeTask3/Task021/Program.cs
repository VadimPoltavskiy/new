Console.WriteLine($"Введите координаты точки A");
Console.Write("xA: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("zA: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координаты точки В");
Console.Write("xВ: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("yВ: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("zB: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double distance = Distance3D(xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);
double resDistance = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точкам: {resDistance}");

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
 return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
}