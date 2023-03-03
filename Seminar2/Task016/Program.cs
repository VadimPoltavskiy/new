Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SquareNumbers(numberA, numberB) ? "Да" : "Нет");

bool SquareNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}