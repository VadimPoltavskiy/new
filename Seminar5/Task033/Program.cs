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

bool SearchDigit(int [] arr, int dig)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] == dig) return true; 
    }
    return false;
}

int [] array = CreateArrayRndInt(10, -100, 100);
PrintArray(array);
Console.WriteLine("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
string output = SearchDigit(array, number) ? "Число присутствует в массиве" : "Число не присутствует в массиве";
Console.WriteLine(output);