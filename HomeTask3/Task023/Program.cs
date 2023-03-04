Console.Write ("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number > 0)
{
 TableСube(number);
}
else
{
    Console.Write ("Введено не натуральное число");
}

void TableСube(int num)
{
     int index = 1;
    while(index<=num)
     {
        int result=index*index*index;
        Console.WriteLine($"{index, 5} {result, 5}");
        index++;
     }
}