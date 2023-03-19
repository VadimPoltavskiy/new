int ConvertToTwo(int number)
{
    int twoNumber = 0;
    int numDigit = 1;
    while (number != 0)
    {
        twoNumber = twoNumber + (number % 2) * numDigit;
        number /= 2;
        numDigit *= 10;
    }
    return twoNumber;
}
Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} в Двоичнной системе равно: {ConvertToTwo(num)}");
