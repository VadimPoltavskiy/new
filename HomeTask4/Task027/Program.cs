Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($" {number} -> {SumNumbers(number)}");


int SumNumbers(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum = sum + num % 10;
        num /=10;
    }
    return sum = sum < 0 ? -sum : sum;
}