// Задача 1 - Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNumbers(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNumbers(num - 1);
}

Console.Write("Input a positive number N: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNumbers(number);
Console.WriteLine();
*/


// Задача 2 - Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int GetSumNum(int num1, int num2)
{
    if (num2 > num1) return GetSumNum(num1, num2 - 1) + num2;
    return num1;
}

Console.Write("Input a positive number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a positive number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0; // если одинаковые числа выведет сумму=0

if (numberM < numberN) sum = GetSumNum(numberM, numberN);
if (numberM > numberN) sum = GetSumNum(numberN, numberM);

Console.WriteLine(sum);
*/


// Задача 3 - Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int functionAkkerman(int n, int m)
{

    if (n == 0) return m + 1;
    if (n > 0)
        if (m == 0) return functionAkkerman(n - 1, 1);
        else if (m > 0) return functionAkkerman(n - 1, functionAkkerman(n, m - 1));

    return 0;
}

Console.WriteLine("Input two positive numbers from 0 to 3: ");
Console.Write("1st number: ");
int argN = Convert.ToInt32(Console.ReadLine());
Console.Write("2nd number: ");
int argM = Convert.ToInt32(Console.ReadLine());
int resultAkkerman;

// !!! Реализовано в значениях до 3
if (argN < 0 || argM < 0 || argN > 3 || argM > 3) Console.WriteLine("Невозможно рассчитать функцию Аккермана с указанными аргументами.");
else
{
    resultAkkerman = functionAkkerman(argN, argM);
    Console.WriteLine($"Function A({argN}, {argM}) = {resultAkkerman}");
}

*/

