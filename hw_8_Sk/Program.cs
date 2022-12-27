// Методы общие для задач 1, 2, 3
int[,] CreateArray2d()
{
    Console.WriteLine("Input a size array:");
    Console.Write("number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a value range of elements:");
    Console.Write("minimum: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("maximum: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(min, max + 1);
    return arr;
}

void ShowArray2d(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача 1 - Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*

void SortElementsOfRowToMin(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int max = arr[i, j];
            for (int k = j + 1; k < arr.GetLength(1); k++)
                if (arr[i, k] > max)
                {
                    max = arr[i, k];
                    arr[i, k] = arr[i, j];
                    arr[i, j] = max;
                }
        }
}

int[,] arrayRandom = CreateArray2d();
ShowArray2d(arrayRandom);
SortElementsOfRowToMin(arrayRandom);
Console.WriteLine("Changed array - sort elements of rows to minimum:");
ShowArray2d(arrayRandom);

*/


// Задача 2 - Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.






// Задача 3 - Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.





// Задача 4 - Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.






// Задача 5 - Напишите программу, которая заполнит спирально массив 4 на 4.


