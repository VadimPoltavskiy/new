Console.WriteLine($"Введите четверть точки:");
string quarter = Console.ReadLine();
Console.WriteLine(Range(quarter));

string Range(string quart)
{
    if(quart == "1") return "x>0, y>0";
    if(quart == "2") return "x<0, y>0";
    if(quart == "3") return "x<0, y<0";
    if(quart == "4") return "x>0, y<0";
    return "Не соответсвует ни какой четверти";
}