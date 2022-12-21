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


void GetUserArguments(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string[] arrTemp = { "k1", "b1", "k2", "b2" };
        Console.Write(arrTemp[i] + " = ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine();
}

Console.WriteLine("Две прямые заданы в плоскости следующим уравнением: у = kx + b");
Console.WriteLine("Укажите значение k и b для каждой прямой, чтобы узнать точку их пересечения в плоскости:");
double[] arr = new double[4];

GetUserArguments(arr);
Console.WriteLine("Ответ:");

if (arr[0] == arr[2])
    if (arr[1] == arr[3]) Console.WriteLine("Множество точек пересечения (прямые совпадают)"); //т.е. заданы одинаковым уравнением
    else Console.WriteLine("Нет точки пересечения (прямые параллельны)"); // кх - угол наклона к Оси Х, b определяют расстояние между прямыми
else
{
    double x = (arr[3] - arr[1]) / (arr[0] - arr[2]);
    double y = arr[2] * x + arr[3];
    Console.WriteLine($"Координаты точки пересечения (x, y) = ({Math.Round(x, 2)}, {Math.Round(y, 2)})"); //ищем, если не относятся к 2м другим вариантам
}
Console.WriteLine("для прямых, заданных следующими уравнениями:");
Console.WriteLine($"у = {arr[0]}x + {arr[1]}");
Console.WriteLine($"у = {arr[2]}x + {arr[3]}");




//_____________________________________________________________________________
// Рабочая версия
/*

void GetUserArguments(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string[] arrTemp = { "k1", "b1", "k2", "b2" };
        Console.Write(arrTemp[i] + " = ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void xyPointsOnLines(double[] arr, double[] xy)
{
    xy[0] = (arr[3] - arr[1]) / (arr[0] - arr[2]);
    xy[1] = arr[2] * xy[0] + arr[3];
}

// bool TestResult(double[] arr, double[] xy)
// {
//     bool result = true;
//     if (xy[1] != arr[0] * xy[0] + arr[1] && xy[1] != arr[2] * xy[0] + arr[3]) result = false;
//     Console.WriteLine($"{xy[1]} = {arr[0]} * {xy[0]} + {arr[1]}"); // для проверки
//     Console.WriteLine($"{xy[1]} = {arr[2]} * {xy[0]} + {arr[3]}"); // для проверки
//     return result;
// }

void ShowSolution(double[] arr, double[] xy)
{
    if (arr[0] == arr[2])
        if (arr[1] == arr[3]) Console.WriteLine("множество точек пересечения (прямые совпадают)"); //т.е. заданы одинаковым уравнением
        else Console.WriteLine("нет точки пересечения (прямые параллельны)"); // кх - угол наклона к Оси Х, b определяют расстояние между прямыми
    else
    {
        xyPointsOnLines(arr, xy);
        Console.WriteLine($"координаты точки пересечения (x, y) = ({Math.Round(xy[0], 2)}, {Math.Round(xy[1], 2)})"); //ищем, если не относятся к 2м другим вариантам
    }
    Console.WriteLine("для прямых, заданных следующими уравнениями:");
    Console.WriteLine($"у = {arr[0]}x + {arr[1]}");
    Console.WriteLine($"у = {arr[2]}x + {arr[3]}");
}

Console.WriteLine("Две прямые заданы в плоскости следующим уравнением: у = kx + b");
Console.WriteLine("Укажите значение k и b для каждой прямой, чтобы узнать точку их пересечения в плоскости:");
double[] arrayUser = new double[4];
double[] xyPoint = new double[2];

GetUserArguments(arrayUser);
// xyPointsOnLines(arrayUser, xyPoint); // нужно ветвление (иначе деление на ноль)
ShowSolution(arrayUser, xyPoint);

// Console.WriteLine("для прямых, заданных следующими уравнениями:");
// Console.WriteLine($"у = {arrayUser[0]}x + {arrayUser[1]}");
// Console.WriteLine($"у = {arrayUser[2]}x + {arrayUser[3]}");

// bool test = TestResult(arrayUser, xyPoint); // для проверки
// Console.WriteLine(test); // для проверки

*/
