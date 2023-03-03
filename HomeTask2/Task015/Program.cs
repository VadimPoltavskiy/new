Console.Write ("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number > 0 && number < 8)
{
    string result = DayWeek(number) ? "ДА" : "НЕТ";
    Console.WriteLine($"{number} -> {result}");
}
else
{
   Console.WriteLine("Введене не корректная цифра");
}

bool DayWeek(int num)
{
    return num == 6 || num == 7;
}