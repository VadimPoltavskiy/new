//int number = new Random().Next(100,1000);
//int firstDigit = number / 100;
//int secondDigit = number % 10;
//int result = firstDigit*10 + secondDigit;
//Console.WriteLine($"{number} -> {result}");

int DelDigit (int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit*10 + secondDigit;
    return result;
}
int number = new Random().Next(100,1000);
int newNumber =  DelDigit(number);
Console.WriteLine($"{number} -> {newNumber}");