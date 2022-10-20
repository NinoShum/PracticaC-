//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
//координат точек в этой четверти (x и y)

string GetXY(int Area)
{
   

    if ( Area == 1 ) return " x > 0, y > 0";
    if ( Area == 2 ) return " x < 0, y > 0";
    if ( Area == 3 ) return " x < 0, y < 0";
    if ( Area == 4 ) return " x > 0, y < 0";

    return "0";

}

Console.WriteLine("Введите четверть: ");
int x = Convert.ToInt32(Console.ReadLine());


string KnownArea = GetXY(x);
Console.WriteLine(KnownArea);