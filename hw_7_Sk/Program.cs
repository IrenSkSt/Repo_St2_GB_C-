
// Задача 1 - Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

}


// Задача 2 - Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Важно! Задача выполнена в продолжение предыдущей.




// Задача 3 - Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void ShowArrayInt(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

}

double[] AverageOfColumns(int arr[,])
{
    double[] result = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); j++)
            sum += arr[i, j];
    }


    return;
}

int[,] arrayUser = CreateArray();
ShowArrayInt(arrayUser);
double[] arrayResult = AverageOfColumns(arrayUser);


