// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] CoordinatesPoints(double k1, double k2, double b1, double b2)
{
    double[] array = new double[2];
    double argX = (b2 - b1) / (k1 - k2);
    double argY = k1 * argX + b1;
    array[0] = argX;
    array[1] = argY;
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

Console.WriteLine("Две прямых заданы уравнениеми y = k1 * x + b1, y = k2 * x + b2 ");
Console.WriteLine("Введите b1");
double enterB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double enterK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double enterB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double enterK2 = Convert.ToDouble(Console.ReadLine());

if (enterK1 != enterK2)
{
    double[] arr = CoordinatesPoints(enterK1, enterK2, enterB1, enterB2);
    PrintArray(arr);
}
else Console.WriteLine("прямые не пересекаются");