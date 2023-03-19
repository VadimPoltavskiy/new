int [] array = CreateArrayRndInt(8, -100, 100);
PrintArray(array);
int  result= SumOddElementsArray(array);
Console.WriteLine($" -> {result} (сумма элементов, стоящих на нечетных позициях)");

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
     Console.Write("]");
}
int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr [i] = rnd.Next(min, max+1);
    }
    return arr;
}
int SumOddElementsArray(int [] arr)
{
    int  res = 0;
    for (int i = 1; i < arr.Length; i+=2 )
    {
        res += arr[i];
    }
    return res;
}