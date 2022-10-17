// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

int x = Convert.ToInt32(Console.ReadLine());    
   
int y = Convert.ToInt32(Console.ReadLine());    

if (y == x*x || x == y * y) Console.WriteLine("yes");
else Console.WriteLine("no");
