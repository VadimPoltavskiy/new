double [] array = CreateArrayRndDouble(8, -100, 100);
PrintArray(array);
double maxValue= MaxValue(array);
double minValue= MinValue(array);
double result = DifferenceMinMaxValue(minValue, maxValue);
Console.WriteLine($" -> {result} (разница между максимальным и минимальным элементами массива)");

void PrintArray (double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
     Console.Write("]");
}
double [] CreateArrayRndDouble(int size, int min, int max)
{
    double [] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble()*(max-min) + min;
        arr [i] = Math.Round(num, 1);
    }
    return arr;
}
double MaxValue(double [] arr)
{
    double  max = arr[0];
    for (int i = 1; i < arr.Length; i++ )
    {
        if(max < arr[i]) max= arr[i];
    }
    return max;
}
double MinValue(double [] arr)
{
    double  min = arr[0];
    for (int i = 1; i < arr.Length; i++ )
    {
        if(min > arr[i]) min= arr[i];
    }
    return min;
}

double DifferenceMinMaxValue(double min, double max)
{
    double res = Math.Round(max - min, 1);
    return res;
}