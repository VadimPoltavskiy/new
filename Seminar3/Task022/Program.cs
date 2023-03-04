Console.Write ("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number > 0)
{
 TableSquare(number);
}
else
  Console.Write ("Введено не натуральное число");

void TableSquare(int num)
{
     int index = 1;
    while(index<=num)
     {
        int result=index*index;
        Console.WriteLine($"{index, 5} {result, 5}");   // форматирование 
        index++;
     }
}