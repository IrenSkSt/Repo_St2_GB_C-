// Задача 1 - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь (без использования массива)

/*
int CountPositiveNum(int q)
{
    int count = 0;
    int number;
    for (int i = 1; i <= q; i++)
    {
        Console.Write($"Введите {i}-е число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    return count;
}

Console.Write("Укажите количество чисел: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int countPositiveNumbers = CountPositiveNum(quantity);
Console.WriteLine($"Вы ввели чисел в количестве: {quantity}, из них было {countPositiveNumbers} > 0");

*/


// Задача 2 - Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. (дополнить вариантами: совпадают, не пересекаются(параллельные))


void GetUserArguments(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string[] arrTemp = { "k1", "b1", "k2", "b2" };
        Console.Write(arrTemp[i] + " = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void xyPointsOnLines(int[] arr, double[] xy) // так не работает
{
    xy[1] = (arr[1] - arr[1 + 2]) / (arr[0] - arr[0 + 2]);
    xy[2] = arr[1] * xy[1] + arr[1 + 2];

}

// bool TestResult()
// {

// }

void ShowSolution(int[] arr, double[] xy)
{
    if (arr[0] == arr[0 + 2])
        if (arr[1] == arr[1 + 2]) Console.WriteLine("множество точек пересечения - прямые совпадают");
        else Console.WriteLine("нет точки пересечения - прямые параллельны");
    else
    {
        xyPointsOnLines(arr, xy);
        Console.WriteLine($"Точка пересечения с координатами (x, y) = ({xy[1]},{xy[2]})");
    }
}

Console.WriteLine("Две прямые заданы в плоскости следующим уравнением: у = kx + b");
Console.WriteLine("Укажите значение k и b для каждой прямой, чтобы узнать точку их пересечения в плоскости:");
int[] arrayUser = new int[4];
double[] xyPoint = new double[2];

GetUserArguments(arrayUser);
// xyPointsOnLines(arrayUser, xyPoint); // нужно ветвление (иначе деление на ноль)
ShowSolution(arrayUser, xyPoint);

// double x = arrayUser[0]; // для проверки
// Console.WriteLine(); // для проверки

Console.WriteLine("Точка пересечения с координатами (x, y) = ({},{}) для прямых, заданных следующими уравнениями:");
Console.WriteLine($"у = {arrayUser[0]}x + {arrayUser[1]}");
Console.WriteLine($"у = {arrayUser[2]}x + {arrayUser[3]}");


