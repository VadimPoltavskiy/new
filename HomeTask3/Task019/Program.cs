Console.Write ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (СheckManyDigit(number, 5))
    Console.WriteLine( FlipMumber(number) == number? $"{number} -> ДА": $"{number} -> НЕТ");
else
    Console.WriteLine( "Введено не пятизначное число!");

bool СheckManyDigit(int num, int sign)
{
    int num1=0;
    num1 = num > 0 ? num : -num;
    return num1 > Math.Pow((10),sign-1)-1 && num1 < Math.Pow((10),sign);
}

int FlipMumber(int num)
{
    if (num != 0)
    {
        int num1 = num < 0 ? -num : num;
        int count1=0;
        int count2=10;
        int flipMumber=0;
        while (num1 > 0)
            {
                count1 = num1 % 10;
                num1 = num1 / 10;
                flipMumber=flipMumber*count2 + count1;
            }
        if (num > 0)
            return count1 = flipMumber;
        else
            return count1 = -flipMumber;
    }
    else
        return num;
}