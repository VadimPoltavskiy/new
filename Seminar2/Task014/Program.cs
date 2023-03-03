Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiple(number) ? "ДА" : "НЕТ");
bool Multiple(int num)
{
 return num%7==0 && num%23==0;
}