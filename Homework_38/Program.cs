// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMinVal(double[] array)
{
    double minVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minVal > array[i]) minVal = array[i];
    }
    return minVal;
}

double FindMaxVal(double[] array)
{
    double maxVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxVal < array[i]) maxVal = array[i];
    }
    return maxVal;
}

Console.WriteLine("Введите размер массив");
int sizeArr = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndDouble(sizeArr, -100, 100);
PrintArray(arr);

double result = FindMaxVal(arr) - FindMinVal(arr);

Console.Write($"Разница между максимальным и минимальный элементами = {result}");