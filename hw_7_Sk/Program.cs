
// Задача 1 - Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] CreateArray2d()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min posible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max posible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[,] arr = new double[rows, columns];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }

    return arr;
}

void ShowArray2dDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

}

double[,] array2dRandom = CreateArray2d();
ShowArray2dDouble(array2dRandom);




// Задача 2 - Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Важно! Задача выполнена в продолжение предыдущей.




// Задача 3 - Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateArray()
{
    Console.WriteLine("Input size array: ");
    Console.Write("numbers of rows = ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("numbers of columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[row, columns];
    int current = 1;
    Console.WriteLine($"Fill {row * columns} elements: ");

    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{current} element: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
            current++;
        }

    Console.WriteLine();
    return arr;
}

void ShowArray2dInt(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

}

void ShowArrayDouble(double[] arr)
{
    Console.WriteLine("Average of each column: ");
    for (int i = 0; i < arr.Length; i++)
        Console.Write(Math.Round(arr[i], 1) + "\t");
    Console.WriteLine();
}

void AverageOfColumns(int[,] arr, double[] arrRes)
{
    for (int j = 0, k = 0; j < arr.GetLength(1) && k < arrRes.Length; j++, k++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++) sum = sum + arr[i, j];

        arrRes[k] = sum / arr.GetLength(0);
        //Console.Write(arrRes[k]); //для проверки
    }
}

int[,] arrayUser = CreateArray();
ShowArray2dInt(arrayUser);
double[] arrayResult = new double[arrayUser.GetLength(1)];

AverageOfColumns(arrayUser, arrayResult);
ShowArrayDouble(arrayResult);

*/

// // Тест Задачи 3:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
