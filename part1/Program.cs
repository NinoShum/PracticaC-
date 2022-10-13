/* Программа, принимает целое число и выдает его квадрат*/ 

// запрос числа от пользователя
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число равно" +" " + number);

// расчкт квадрата

int sqrNumber = number * number;

// формула, но применяется к вещ.цифрам (надо выбрать double, а не int)
//sqrNumber1 = Math.Pow (number, 2)

//вывод результата
Console.WriteLine($"Квадрат числа = {sqrNumber}");
