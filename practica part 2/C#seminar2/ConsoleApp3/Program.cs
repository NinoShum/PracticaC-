﻿/*Напишите программу, которая будет принимать на вход два числа 
 * и выводить, является ли второе число кратным первому. 
 * Если число 2 не кратно числу 1, то программа 
 * выводит остаток от деления. */

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int c = b % a;

if ( c == 0)
{
    Console.WriteLine("кратно");
}

else
{
    Console.WriteLine($"не кратное, остаток {c}");
}

