// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[] SumColumnsMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i],5}, ");
        else Console.Write($"{array[i],5}");
    }
    Console.WriteLine("]");
}

int SearchMinElementArray(int[] array)
{
    int minElement = array[0];
    int NumElement = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
            NumElement = i;
        }
        
    }
    return NumElement;
}

int[,] array2D = CreateMatrixRndInt(7, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] resultArr = SumColumnsMatrix(array2D);
PrintArray(resultArr);
Console.WriteLine();

int resultRow = SearchMinElementArray(resultArr);
Console.WriteLine($"Наименьшая сумма в строке {resultRow+1}");      //для вывода результата счет строк начинается с 1
