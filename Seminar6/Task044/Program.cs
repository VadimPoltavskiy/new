Console.WriteLine("Введите число N: ");
int number =Convert.ToInt32(Console.ReadLine());

int [] fiboArray = FibonacciArray(number);
PrintArray (fiboArray);

int[] FibonacciArray (int num)
{
  int [] array = new int [num];
  array[1] = 1;
 for (int i = 2; i < num; i++)
 {
    array[i]=array[i-1] +array[i-2];
 }
 return array;
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