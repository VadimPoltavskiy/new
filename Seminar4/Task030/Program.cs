int[] array1 = new int[8];

RandomArray(array1);
PrintArray(array1);

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
