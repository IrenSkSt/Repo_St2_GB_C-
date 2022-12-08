// Задача 1 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int NumDes(int num)
{
    return num / 10 % 10;
}

Console.Write("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 1000)
{
    int result = NumDes(number);
    Console.WriteLine("Вторая цифра в этом числе = " + result);
}
else Console.WriteLine("Ваше число не является трехзначным");
*/


// Задача 2 - Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

bool NumControl(int num)
{
    if (num / 100 == 0) return false;
    return true;
}

int FindThirdNum(int fullNum)
{
    int numTemp = fullNum;
    while (numTemp / 1000 != 0)
    {
        numTemp = numTemp / 10;
    }
    return numTemp % 10;
}

Console.Write("Введите любое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool control = NumControl(number);
if (control == true)
{
    int result = FindThirdNum(number);
    Console.WriteLine("Третья цифра в числе = " + result);
}
else Console.WriteLine("В этом числе нет 3-й цифры");
*/


// Задача 3 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*

bool IsWeekend(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}

void PrintAnswer(bool res)
{
    if (res == true) Console.WriteLine("Это выходной день!");
    else Console.WriteLine("Этот день не является выходным");
}

Console.Write("Какой сегодня день недели? Укажите номер в диапазоне от 1 до 7: ");
int numDayOfWeek = Convert.ToInt32(Console.ReadLine());


if (numDayOfWeek < 1 || numDayOfWeek > 7)
{
    Console.WriteLine("Вы указали день недели некорректно. В неделе 7 дней. Нумерация с единицы, которая соответствует понедельнику.");
}
else
{
    bool result = IsWeekend(numDayOfWeek);
    PrintAnswer(result);
}
*/


