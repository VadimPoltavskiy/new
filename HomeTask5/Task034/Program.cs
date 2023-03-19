int [] array = CreateArrayRndInt(8, 100, 999);
PrintArray(array);
int  result= NumberOfEvenArrayElements(array);
Console.WriteLine($" -> {result} (Kоличество четных элементов массива)");

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
int NumberOfEvenArrayElements(int [] arr)
{
    int  res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }
    return res;
}