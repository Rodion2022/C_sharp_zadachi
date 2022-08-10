// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
}
else
{
    Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
Console.WriteLine("максимальное из введённых чисел" + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");

number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 1)
{
    Console.WriteLine("Число " + number1 + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + number1 + "является: ЧЁТНЫМ");
}