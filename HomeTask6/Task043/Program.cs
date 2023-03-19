Console.WriteLine ("y = k1*x + b1");
Console.Write ("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("y = k2*x + b2");
Console.Write ("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (ErrorСhecking(k1, k2))
{
  double [] coordinates = IntersectionCoordinates(b1, k1, b2, k2);
  Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
  PrintArray (coordinates);
}
else 
   Console.WriteLine("ERROR: Прямые или паралельны или совпадают");

void PrintArray (double [] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(")");
}

double [] IntersectionCoordinates(double b1, double k1, double b2, double k2)
{
   double [] arr = new double [2];
   arr[0] = Math.Round((b2-b1)/(k1-k2), 2);
   arr[1] = Math.Round(arr[0]*k1 + b1, 2);
   return arr;
}
bool ErrorСhecking(double k1, double k2)
{
    if (k1 != k2) return true;
    else return false;
}