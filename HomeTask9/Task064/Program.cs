Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckingNaturalNumber(number))
{
    Console.Write($"N = {number} -> '");
    NaturalNumbers(number);
    Console.Write("'");
}
else
{
    Console.WriteLine("Error: Введено не натурально число.");
}


bool CheckingNaturalNumber(int num)
{
    if (num>0) return true;
    else return false;
}

void NaturalNumbers(int num)
{
    if(num == 1) 
    {
        Console.Write(1);
        return;
    }
    Console.Write($"{num} ");
    NaturalNumbers(num-1);
}
