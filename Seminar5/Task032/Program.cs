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

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void ChangeSing(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = - arr [i];
    }
}

int [] array = CreateArrayRndInt(10, -100, 100);
PrintArray(array);
ChangeSing(array);
PrintArray(array);