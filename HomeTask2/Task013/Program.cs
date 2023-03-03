Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number > 99)
{
    Console.WriteLine($"{number} -> {ThirdDigit(number)}");
}
else
{
   Console.WriteLine("Третьей цифры нет");
}

int ThirdDigit(int num)
{
    while (num >= 999)
    {
        num = num/10;
    }
    return num%10;
}