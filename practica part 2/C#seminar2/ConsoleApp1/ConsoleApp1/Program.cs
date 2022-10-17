// Найти максимальное из трех чисел

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
    {
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($" Максимальное из чисел {max}");
Console.ReadKey();
