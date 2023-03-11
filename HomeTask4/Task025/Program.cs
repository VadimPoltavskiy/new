Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
    Console.WriteLine( $"{number1}, {number2} -> {Exponentiation (number1, number2)}");  
else
    Console.WriteLine( "Введено не натуральное число B");

int Exponentiation(int arg1, int arg2)
{
    int res = 1;
    for (int i = 0; i < arg2; i++)
    {
        res= res*arg1;
    }
    return res;
}