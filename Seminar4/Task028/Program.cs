Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int compositionNumbers = CompositionNumbers(number);
Console.WriteLine($" {number} -> {compositionNumbers}");


int CompositionNumbers(int num)
{
    int composition = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            composition = composition * i;
        }
    }
    return composition;
}