Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine()); 
if (numberA > numberB)
  if (numberA  > numberC)
     Console.Write (numberA);
   else 
     Console.Write (numberC);
else
  if (numberB > numberC) 
      Console.Write (numberB);
    else
      Console.Write (numberC);


