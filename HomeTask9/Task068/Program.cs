Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (CheckingPositiveNumber(numberM) && CheckingPositiveNumber(numberN))
{
    int result = AckermanFunction(numberM, numberN);
    Console.Write($"m = {numberM}; n = {numberN} -> A(m,n) = {result}");
}
else
{
    Console.WriteLine("Error: Значения должны быть: m>=0; n>=0.");
}


int AckermanFunction(int m, int n)
{
   while (m != 0)
   {
    if(n==0) n=1;
    else n=AckermanFunction(m, n-1);
    m=m-1;
   }
   return n+1;
}

bool CheckingPositiveNumber(int num)
{
    if (num>=0) return true;
    else return false;
}