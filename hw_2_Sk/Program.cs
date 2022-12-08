// Задача 1 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = -1;

int NumDes(int num)
{
    return result = number / 10 % 10;
}

if (number > 100 && number < 1000)
{
    result = NumDes(number);
    Console.WriteLine("Вторая цифра в этом числе = " + result);
}
else Console.WriteLine("Ваше число не является трехзначным");
*/



// Задача 2 - Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите любое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
bool control = true;

bool NumControl(int num)
{
    if (num / 100 == 0) control = false;
    return control;
}

int FindThirdNum(int fullNum)
{
    int numTemp = fullNum;
    while (numTemp / 1000 != 0)
    {
        numTemp = numTemp / 10;
    }
    return result = numTemp % 10;
}

control = NumControl(number);
if (control == true)
{
    result = FindThirdNum(number);
    Console.WriteLine("Третья цифра в числе = " + result);
}
else Console.WriteLine("В этом числе нет 3-й цифры");

*/


// Задача 3 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Какой сегодня день недели? Укажите номер в диапазоне от 1 до 7: ");
int numDayOfWeek = Convert.ToInt32(Console.ReadLine());
bool result = false;

bool IsWeekend(int num)
{
    if (num == 6 || num == 7)
    {
        result = true;
    }
    return result;
}

void PrintAnswer(bool res)
{
    if (res == true) Console.WriteLine("Это выходной день!");
    else Console.WriteLine("Этот день не является выходным");
}

if (numDayOfWeek < 1 || numDayOfWeek > 7)
{
    Console.WriteLine("Вы указали день недели некорректно. В неделе 7 дней. Нумерация с единицы, которая соответствует понедельнику.");
}
else
{
    IsWeekend(numDayOfWeek);
    PrintAnswer(result);
}
*/

