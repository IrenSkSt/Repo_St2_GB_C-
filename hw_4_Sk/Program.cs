// Задача 1 - Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

/*
int MathPowNum(int num, int pow)
{
    int result = num;
    for (int i = pow; i > 1; i--) result = result * num;

    return result;
}

Console.Write("Укажите 1-ое положительное число: "); // по умолчанию: пользователь вводит в соответствии с требованиями(проверки не реализованы)
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите 2-ое положительное число: "); //для отрицательной степени не реализовано
int power = Convert.ToInt32(Console.ReadLine());
int numberToPower = 1;

if (power != 0) numberToPower = MathPowNum(number, power);

Console.WriteLine($"Число {number} в степени {power} = {numberToPower}");
*/



// Задача 2 - Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

/*
int SumComponentsOfNum(int num)
{
    int sum = 0;
    int temp = num;
    while (temp != 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    return sum;
}

Console.Write("Укажите положительное число: "); //по умолчанию: пользователь вводит нужное (проверки не реализованы)
int number = Convert.ToInt32(Console.ReadLine());

int sumComponentsOfNumber = SumComponentsOfNum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumComponentsOfNumber}");
*/


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

/*
void CreateArray(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Укажите {i + 1}-й элемент массива (целое число): ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

}

void ShowArray(int[] arr, int size)
{
    for (int i = 0; i < size; i++) Console.Write(arr[i] + " ");
}

Console.Write("Укажите количество элементов в массиве: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lengthArray];
CreateArray(array, lengthArray);

Console.Write("Массив состоит из следующих чисел: ");
ShowArray(array, lengthArray);
Console.WriteLine();
*/
