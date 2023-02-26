Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number < 0) number = -number;
if (number > 99 && number < 1000)
{
    number = number % 10;
    Console.Write (number);
}
else
{
    Console.Write ("Введено не трехзначное число ");
}

