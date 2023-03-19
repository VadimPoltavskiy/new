Console.Write ("Введите количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] array = СompletionArray(size);
    int quantity = QuantityOfPositivNumbersArray(array);
    PrintArray (array);
    Console.Write($"  ->  {quantity}");
}
else
{
    Console.Write("Количество вводимых чисел не может быть отрецательным или равным 0");
}

int QuantityOfPositivNumbersArray(int [] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) quantity++;
        }
    return quantity;
}

int [] СompletionArray(int num)
{
    int [] arr = new int [num];
    for (int i = 0; i < num; i++)
    {
        Console.Write ($"Введите число {i+1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}