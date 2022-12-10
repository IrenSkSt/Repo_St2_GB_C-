// Задача 1 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (зеркальным).

int DigitNum(int num, int digit)
{
    while (num != 0)
    {
        num = num / 10;
        digit++;
    }
    return digit;
}

bool IsMirrorNum(int num, int pow)
{
    int middle = pow / 2;
    int step = 0;

    while (step <= middle)
    {
        step++;
        pow--;
        // Console.WriteLine(pow + " " + step); // для проверки
        // Console.WriteLine(num / Convert.ToInt32(Math.Pow(10, pow)) % 10); // для проверки
        // Console.WriteLine(num % Convert.ToInt32(Math.Pow(10, step)) / Convert.ToInt32(Math.Pow(10, step - 1))); // для проверки

        if (num / Convert.ToInt32(Math.Pow(10, pow)) % 10 != num % Convert.ToInt32(Math.Pow(10, step)) / Convert.ToInt32(Math.Pow(10, step - 1)))
        {
            Console.WriteLine("Это число не является палиндромом (зеркальным)");
            return false;
        }


    }
    return true;
}


Console.Write("Введите положительное 5тизначное число: "); //задача имеет смысл и проверка имеет смысл только если в числе хотя бы 2 разряда
int number = Convert.ToInt32(Console.ReadLine());
int power = 0;
bool result = false;

if (number < 0 || number < 10) Console.WriteLine("Вы ввели число, не соответствующее запросу. Проверьте и повторите попытку.");
else
{
    power = DigitNum(number, power);
    //Console.WriteLine(power); //для проверки определения разрадности числа
    result = IsMirrorNum(number, power);
    if (result == true) Console.WriteLine("Это число является палиндромом (зеркальным)");
}





// Задача 2 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


/*
Console.Write("x = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates point A:");



*/



// Задача 3 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void LineCubNum(int num, int i)
{
    if (num == 1) Console.WriteLine("Число возведенное в куб = 1");
    if (num > 1)
    {
        Console.WriteLine($"Числа, возведенные в куб, начиная от 1 до {num}: ");
        while (i <= num)
        {
            Console.Write(Math.Pow(i, 3) + " ");
            i++;
        }

    }
    else Console.WriteLine("Вы указали некорректное число. Проверьте и повторите попытку.");
}

Console.Write("Укажате целое число, начиная от 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
LineCubNum(number, current);
Console.WriteLine();

*/
