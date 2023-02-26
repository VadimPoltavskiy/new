Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine()); 
if (numberB > numberA)
{
    Console.Write ($" max = {numberB}");
}
else
{
    if (numberA == numberB)
      {Console.Write ("Введены одинаковые числа");}
    else
      {Console.Write ($" max = {numberA}");}
}


