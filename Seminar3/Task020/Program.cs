Console.WriteLine($"Введите координаты точки A");
Console.Write("xA: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координаты точки В");
Console.Write("xВ: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("yВ: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xCoordA, yCoordA, xCoordB, yCoordB);
double resDistance = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точкам: {resDistance}");

double Distance(int x1, int y1, int x2, int y2)
{
 return Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));
}