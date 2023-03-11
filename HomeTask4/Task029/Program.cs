int[] array = new int[8];

RandomArray(array);
PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.Write("]");

void RandomArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= rnd.Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}");
}
