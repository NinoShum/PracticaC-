// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

// <Возвращаемый тип данных> <Наименование метода> (переменные) {тело метода }

int GetPointArea( int coorX, int coorY )
{
    int numberArea = 0;
    if ( coorX > 0 && coorY > 0 )
    {
        numberArea = 1;
    }
    if ( coorX < 0 && coorY > 0 )
    {
        numberArea = 2;
    }
    if ( coorX < 0 && coorY < 0 )
    {
        numberArea = 3;
    }
    if (coorX > 0 && coorY < 0 )
    {
        numberArea = 4;
    }

    return numberArea;

}

Console.WriteLine("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x,y);
Console.WriteLine(numberArea);

/*  что-то не работает
void GetPointArea( int coorX, int coorY )
{
  
    if ( coorX > 0 && coorY > 0 )
    {
        Console.WriteLine("1");
    }
    if ( coorX < 0 && coorY > 0 )
    {
        Console.WriteLine("2");
    }
    if ( coorX < 0 && coorY < 0 )
    {
        Console.WriteLine("3");
    }
    if (coorX > 0 && coorY < 0 )
    {
        Console.WriteLine("4");
    }
        else
    Console.WriteLine("0");

}

Console.WriteLine("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

GetPointArea(x,y);
*/