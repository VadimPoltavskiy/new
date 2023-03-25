Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigitsInTheNumber =SumDigitsInTheNumber(number);
Console.WriteLine($"{number} -> {sumDigitsInTheNumber}");


int SumDigitsInTheNumber(int num)
{
    if(num == 0) return num;
    return num % 10 + SumDigitsInTheNumber (num/10);
}
