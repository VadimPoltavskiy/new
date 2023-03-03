Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = RemainsDigits(numberA, numberB);
string resultLine = result == 0 ? "Кратно" : $"Не кратно, остаток {result}";
Console.WriteLine(resultLine);
//или
//Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток {result}");

int RemainsDigits(int num1, int num2)
{
 return num1 % num2;
}
