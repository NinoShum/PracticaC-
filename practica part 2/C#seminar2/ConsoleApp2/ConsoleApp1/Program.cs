/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.*/

int a = new Random().Next(100, 1000);
Console.WriteLine(a);

int c = a % 10;
Console.WriteLine(c);

int d = a / 100;
Console.WriteLine(d);

a = (d * 10) + c;
Console.WriteLine(a);

