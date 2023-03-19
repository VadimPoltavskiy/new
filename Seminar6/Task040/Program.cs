Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

string output = IsExistTriangle(number1, number2, number3) ? "Треугольгик может существовать с такими сторонами"
: "Треугольгик не может существовать с такими сторонами";
Console.WriteLine(output);

bool IsExistTriangle(int a, int b, int c)
{
  if (a + b > c && b + c > a && c + a > b) return true;
  else return false;
}