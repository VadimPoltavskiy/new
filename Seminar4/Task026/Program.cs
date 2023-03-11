Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int countDigit = HowManyDigit(number);
Console.WriteLine($" {number} -> {countDigit}");

int HowManyDigit(int num)
{
    int count=0;
    do
        {
            num /= 10; //num = num / 10;
            count++;
        } while (num != 0);
    return count;
}