Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine()); 
if (numberB*numberB == numberA)
{
    Console.Write ($"ДА Квадрат числа {numberB} = {numberA}");
}
else
{
    Console.Write ($"НЕТ Квадрат числа {numberB} не равно {numberA}");
}

