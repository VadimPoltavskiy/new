Console.Write ("Введите первое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine()); 

//if (number == 1) Console.Write ("Понедельник");
// else if (number == 2) Console.Write ("Вторник");
// else if (number == 3) Console.Write ("Среда");
// else if (number == 4) Console.Write ("Четверг");
// else if (number == 5) Console.Write ("Пятница");
// else if (number == 6) Console.Write ("Суббота");
// else if (number == 7) Console.Write ("Воскресенье");
//else Console.Write ("Число указано не верно");

switch (number)
{  case 1:
      Console.Write ("Понедельник");
      break;
   case 2:
      Console.Write ("Вторник");
      break;
   case 3:
      Console.Write ("Среда");
      break;
   case 4:
      Console.Write ("Четверг");
      break;
   case 5:
      Console.Write ("Пятница");
      break;
   case 6:
      Console.Write ("Суббота");
      break;
   case 7:
      Console.Write ("Воскресенье");
      break;
    default:
      Console.Write ("Число указано не верно");
      break;
}