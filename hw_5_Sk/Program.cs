int[] CreateRandomIntArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}

double[] CreateRandomDoubleArray(double[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 2);
    return arr;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

void ShowDoubleArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

// Задача 1 - Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int CountOddNumbers(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) temp++;
    return temp;
}

Console.Write("Задайте размер массива (число элементов в нем): ");
int lengthMyArray = Convert.ToInt32(Console.ReadLine());

int[] MyArray = new int[lengthMyArray];
MyArray = CreateRandomIntArray(MyArray, 100, 1000);
ShowArray(MyArray);
int count = CountOddNumbers(MyArray);
Console.WriteLine("Количество чётных чисел в массиве = " + count);
*/


// Задача 2 - Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (визуально для пользователя).

/*
int SumElementsOddPositionUser(int[] arr)
{
    int sumTemp = 0;
    for (int i = 0; i < arr.Length; i += 2) sumTemp += arr[i];
    return sumTemp;
}

Console.Write("Задайте размер массива (количество элементов): ");
int lengthMyArray2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение (для диапазона значений элементов массива): ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение (для диапазона значений элементов массива): ");
int maxRange = Convert.ToInt32(Console.ReadLine());

int[] MyArray2 = new int[lengthMyArray2];
MyArray2 = CreateRandomIntArray(MyArray2, minRange, maxRange);
ShowArray(MyArray2);
int sum = SumElementsOddPositionUser(MyArray2);
Console.WriteLine("Сумма нечетных элементов массива = " + sum);
*/

// Задача 3 - Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double DifferensMinMaxOfArray(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    //Console.WriteLine(min); //для проверки
    //Console.WriteLine(max); //для проверки
    return max - min;
}

Console.Write("Укажите количество элементов в массиве: ");
int lengthMyArray3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте Минимум для значений элементов массива: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте Максимум для значений элементов массива: ");
int maxRange = Convert.ToInt32(Console.ReadLine());

double[] myArray3 = new double[lengthMyArray3];
//ShowDoubleArray(myArray3); // для проверки

myArray3 = CreateRandomDoubleArray(myArray3, minRange, maxRange);
ShowDoubleArray(myArray3);
double result = Math.Round(DifferensMinMaxOfArray(myArray3), 2);
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + result);

