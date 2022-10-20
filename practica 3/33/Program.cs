// Напишите программу, которая принимает
// на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

/* формула
int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2))
*/

double Formula( int x1, int y1, int x2, int y2 )
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return distance;
}

Console.WriteLine("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Formula(x1,y1,x2,y2);
Console.WriteLine(distance);
