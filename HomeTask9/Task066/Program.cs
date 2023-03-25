Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = SumOfNaturalElementsNumbers(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> {result}");

int SumOfNaturalElementsNumbers(int arg1, int arg2)
{
    if(arg1 == arg2) 
    {
        return arg2; 
    }
    
    if (arg1>arg2)
    {
        return arg2 + SumOfNaturalElementsNumbers(arg1, arg2+1);
    }
    else
    {
        return arg2 + SumOfNaturalElementsNumbers(arg1, arg2-1);
    }
}
