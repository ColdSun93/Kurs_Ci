// 17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта
// точка.

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int Quarter(int xc, int yc)
// {
//     if (xc > 0 && yc > 0) return 1;
//     if (xc < 0 && yc > 0) return 2;
//     if (xc < 0 && yc < 0) return 3;
//     if (xc > 0 && yc < 0) return 4;
//     return 0;
// }

// int quarter = Quarter(x, y);
// string result = quarter > 0
//                 ? $"Указанные координаты соответсвую четверти-> {quarter}"
//                 : "Введены некоректные координаты";
// Console.WriteLine(result);

//*******************************************************************************

// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// string Range(int quar1)
// {
//     switch (quar1)
//     {
//         case 1: return "X > 0 и Y > 0";
//         case 2: return "X  < 0 и Y > 0";
//         case 3: return "X  < 0 и Y < 0";
//         case 4: return "X  > 0 и Y < 0";
//         default: return "Введено некоректное значение";
//     }
// }

// Console.WriteLine("Введите номер четверти");
// int quartet = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Range(quartet));

//*******************************************************************************
// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double Distance(int xc, int yc, int xb, int yb)
// {
//     double result = Math.Sqrt(Math.Pow((xb - xc), 2) + Math.Pow((yb - yc), 2));
//     return Math.Round(result, 2, MidpointRounding.ToZero);
// }

// Console.WriteLine("Введите координаты первой точки");
// Console.Write("X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки");
// Console.Write("X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Расстояние между точек = {Distance(x1, y1, x2, y2)}");

//*******************************************************************************

// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


void Table(int n1)
{
    if (n1 > 0)
    {
        int count = 1;
        while (count <= n1)
        {
            Console.WriteLine($"|{count,4}|  |{Math.Pow(count, 2),4}|");
            count++;
        }
    }
    else Console.WriteLine("Некорректное значение");
}

Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);