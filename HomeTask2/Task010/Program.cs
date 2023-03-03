Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number > 99 && number < 1000)
{
    Console.WriteLine($"{number} -> {SecondDigit(number)}");
}
else
{
   Console.WriteLine("введено не трехзначное число");
}

int SecondDigit(int num)
{
    return num/10%10;
}
