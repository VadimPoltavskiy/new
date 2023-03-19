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

int GetSumNegativElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum +=arr[i];
    }
    return sum;
}

int GetSumPositivElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum +=arr[i];
    }
    return sum;
}

int [] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumNegativElem = GetSumNegativElem(array);
int sumPositivElem = GetSumPositivElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositivElem}");
Console.WriteLine($"Сумма отрецательных элементов = {sumNegativElem}");