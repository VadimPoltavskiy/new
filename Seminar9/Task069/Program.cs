Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB= Convert.ToInt32(Console.ReadLine());
double result =RowNumber(numberA, numberB);
Console.WriteLine($"А = {numberA}; B = {numberB} -> {result}");


double RowNumber(int a, int b)
{
    if(b < 0)
    {
        return 1 /(a/RowNumber(a,b+1));
    } 
    else if (b < 0)
    {
        return a * RowNumber(a, b-1);
    }
    else  return 1;
}
