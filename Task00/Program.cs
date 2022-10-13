// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число
// умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.Write("Введите целое число ");
// int numA = Convert.ToInt32(Console.ReadLine());
// int square = numA * numA;

// Console.WriteLine($"Квадрат числа {numA} = {square}");

//bool res = numA > 5 && numA < 10; //true - false
//if (res)

//**************************************************************************

// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA == numB*numB)
// {
//     Console.WriteLine($"{numB} является квадратом числа {numA}");
// }
// else
// {
//     Console.WriteLine($"{numB} не является квадратом числа {numA}");
// }


//**************************************************************************

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите день недели в формате числа ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA > 0 && numA < 8)
{
    if (numA == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (numA == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (numA == 3)
    {
        Console.WriteLine("Среда");
    }
    if (numA == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (numA == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (numA == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (numA == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}
else
{
    Console.WriteLine("Некорректное значение");
}