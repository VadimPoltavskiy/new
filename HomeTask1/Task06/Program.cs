Console.Write ("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
numberA = numberA % 2;
  if (numberA == 0)
     Console.Write ("Число является четным");
   else 
     Console.Write ("Число является не четным");
