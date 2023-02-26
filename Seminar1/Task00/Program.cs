//На вход принимается число и выдается квадрат этого числа.

Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); //преобразовали введеное значение из строки в формат int
int square = number * number;
//Console.Write ("Квадрат числа ");
//Console.Write (number);
//Console.Write (" = ");
//Console.WriteLine (square);
Console.Write ($"Квадрат числа {number} = {square}");  //замена 4 строк выше, всего на одну эту строку