Console.WriteLine($"Введите координаты точки");
Console.Write("Х: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoord, yCoord);
string result = quarter > 0 ? 
   $"указанные координаты соответствует {quarter} четверти."
   : "Введены некорруктные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y<0) return 3;
    if(x>0 && y<0) return 4;
    return 0;
}