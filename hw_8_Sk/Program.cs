// Методы общие для задач 1, 2, 3, 5
/*
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
*/

/*
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
*/

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


// Задача 2 - Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. (Указываем пользовательский номер строки, т.е. нумерация - с 1).

/*

int FindMinSumElementsOfRow(int[,] arr)
{
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
        // if (sum = minSum) Console.WriteLine("in row № " + i);
        //Console.WriteLine(i + "стр - сумма: " + sum); //для проверки
    }
    return minRow;
}

int[,] arrayRandom = CreateArray2d();
ShowArray2d(arrayRandom);
//if (arrayRandom.GetLength(0) != arrayRandom.GetLength(1)) Console.WriteLine("Эта матрица не прямоугольная (т.к. количество строк не равно количеству столбцов)");
int rowMinSumElem = FindMinSumElementsOfRow(arrayRandom);
Console.WriteLine("Minimum sum of elements in row № " + (rowMinSumElem + 1));
*/


// Задача 3 - Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Умножить Матрицу 1 на Матрицу 2 можно, если число столбцов М1 равняется числу строк М2 
// Произведение матрицы A размера m × n и матрицы B размера n × k  — это матрица C размера m × k, в которой элемент c i j ​равен сумме произведений элементов i строки матрицы A на соответствующие элементы j столбца матрицы B : c i j = a i 1 b 1 j + a i 2 b 2 j + . . . + a i n b n j​. 
// Умножение матриц осуществляется путем умножения строки на столбец. Находятся произведения первого элемента строки и первого элемента столбца, второго элемента строки и второго элемента столбца и т.д. Затем полученные произведения суммируются.

/*

void Arr1MultiplicationArr2(int[,] arr1, int[,] arr2, int[,] arrResult)
{
    for (int i = 0; i < arrResult.GetLength(0); i++)
        for (int j = 0; j < arrResult.GetLength(1); j++)
            for (int m = 0, n = 0; m < arr1.GetLength(1) && n < arr2.GetLength(0); m++, n++)
                arrResult[i, j] += arr1[i, m] * arr2[n, j];
}

int[,] arrayRandom1 = CreateArray2d();
Console.WriteLine("Matrix 1: ");
ShowArray2d(arrayRandom1);
int[,] arrayRandom2 = CreateArray2d();
Console.WriteLine("Matrix 2: ");
ShowArray2d(arrayRandom2);

if (arrayRandom1.GetLength(1) == arrayRandom2.GetLength(0))
{
    int[,] arrayMultiplication = new int[arrayRandom1.GetLength(0), arrayRandom2.GetLength(1)];
    Arr1MultiplicationArr2(arrayRandom1, arrayRandom2, arrayMultiplication);
    ShowArray2d(arrayMultiplication);
}
else Console.WriteLine("Матрицу1 нельзя перемножить на Матрицу2. Количество столбцов Матрицы 1 должно равняться количеству строк Матрицы 2");

*/



// Задача 4 - Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Вывод слоями.

/*

void Create3dArrayRandom(int[,,] arr, int min, int max)
{

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                //arr[i, j, k] = new Random().Next(min, max + 1); // 1й вариант: генерация без проверки на дубль значений

                if (i == 0 && j == 0 && k == 0) arr[i, j, k] = new Random().Next(min, max + 1);
                else
                {
                    bool isOneNum = false;
                    while (isOneNum == false)
                    {
                        arr[i, j, k] = new Random().Next(min, max + 1);
                        // Console.Write(arr[i, j, k] + "\t"); // для проверки
                        isOneNum = CheckRepeatValue(arr, arr[i, j, k], i, j, k); // проверка на дубль
                        // Console.Write(isOneNum + "\t"); // для проверки
                        if (isOneNum == true) break;
                    }


                }
            }
}

bool CheckRepeatValue(int[,,] arr, int num, int i, int j, int k)
{
    bool isOne = true;
    for (int x = 0; x < arr.GetLength(0); x++)
        for (int y = 0; y < arr.GetLength(1); y++)
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                // Console.Write(arr[x, y, z] + "=" + num + "\t"); // для проверки
                if (arr[x, y, z] == num)
                    if (x == i && y == j && z == k) isOne = true; //Console.WriteLine("Сравниваем само с собой"); // для проверки
                    else return isOne = false;
                // Console.Write(isOne); // для проверки

            }
    // Console.Write(isOne);
    return isOne;
}

void ShowArray3d(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        Console.WriteLine((k + 1) + "-й слой");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                //Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})" + "\t"); // вариант с координатами - подходит для проверки
                Console.Write(arr[i, j, k] + "\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }



}

Console.WriteLine("Input size of 3d array: ");
Console.Write("1st dimension: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("2nd dimension: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("3rd dimension: ");
int z = Convert.ToInt32(Console.ReadLine());
int min = 10, max = 99;

if (x * y * z <= (max - min)) // возможность неповторять двузначные числа
{
    int[,,] array3dRandom = new int[x, y, z];
    Create3dArrayRandom(array3dRandom, min, max);
    ShowArray3d(array3dRandom);
}
else Console.WriteLine("Невозможно создать 3-хмерный массив такого размера с НЕповторяющимися двузначными значениями.");

*/



// Задача 5 - Напишите программу, которая заполнит спирально массив 4 на 4.
//TO WORK: Работает 2х2, 3х3, 4х4 - а дальше надо разбираться с зависимостями и дорабатывать.

/*

void FillSpiralArray2d(int[,] arr, int size)
{
    int count = 0;
    int a = 0;
    int b = 0;
    int n = size;

    while (count < arr.Length)
    {
        for (int i = a, j = b; j < n; j++)
        {
            if (count++ >= arr.Length) break;
            arr[i, j] = count;
            //Console.Write(arr[i, j] + $"[{i},{j}] "); //для проверки
        }
        a++;

        for (int i = a, j = n - 1; i < n; i++)
        {
            if (count++ >= arr.Length) break;
            arr[i, j] = count;
            //Console.Write(arr[i, j] + $"[{i},{j}] "); //для проверки
        }
        n--;

        for (int i = n, j = n - 1; j > 0; j--)
        {
            if (count++ >= arr.Length) break;
            arr[i, j] = count;
            //Console.Write(arr[i, j] + $"[{i},{j}] "); //для проверки
        }

        for (int i = n, j = b; i > 0; i--)
        {
            if (count++ >= arr.Length) break;
            arr[i, j] = count;
            //Console.Write(arr[i, j] + $"[{i},{j}] "); //для проверки
        }
        Console.WriteLine();
        b++;
    }
}


Console.Write("Input size square matrix: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];
FillSpiralArray2d(array, n);
ShowArray2d(array);

*/
