// Задача 1 - Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) Console.WriteLine(num1 + " больше " + num2);
else if (num2 > num1) Console.WriteLine(num2 + " больше " + num1);
else Console.WriteLine("Эти числа равны");
*/


// Задача 2 - Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("Максимальное из этих чисел = " + max);
*/


// Задача 3 - Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine("Это чётное число");
else Console.WriteLine("Это нечётное число");
*/

// Задача 4 - Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

if (num < 2) Console.WriteLine("Нет чётных положительных чисел в диапазоне между 1 и введенным Вами числом.");
else
{
    while (current <= num)
    {
        if (current % 2 == 0) Console.Write(current + " ");
        current++;
    }
}
*/
