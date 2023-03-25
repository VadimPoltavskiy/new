Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(M, N);

void ShowNumbers(int arg1, int arg2)
{
    if(arg1 == arg2) 
    {
        Console.Write($"{arg2} "); 
        return;
    }

    if (arg1>arg2)
    {
        ShowNumbers(arg1, arg2+1);
        Console.Write($"{arg2} ");
    }
    else
    {
        ShowNumbers(arg1, arg2-1);
        Console.Write($"{arg2} ");
    }
}
