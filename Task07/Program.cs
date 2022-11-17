// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1    4   8   19
// 5    -2  33  -2
// 77   3   8   1

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1 
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j != matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
//             else Console.Write($"{matrix[i, j],5}");
//         }
//         Console.WriteLine(" |");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(array2D);

//**************************************************************

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] CreateMatrixSumIndexInt(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1 

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j != matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
//             else Console.Write($"{matrix[i, j],5}");
//         }
//         Console.WriteLine(" |");
//     }
// }

// int[,] array2D = CreateMatrixSumIndexInt(3, 4);
// PrintMatrix(array2D);


//**************************************************************
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1 
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j != matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
//             else Console.Write($"{matrix[i, j],5}");
//         }
//         Console.WriteLine(" |");
//     }
// }

// void SqrEvenElements(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//         }

//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(array2D);
// Console.WriteLine("");
// SqrEvenElements(array2D);
// PrintMatrix(array2D);


//**************************************************************

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

int SumMatrixSinh(int[,] matrix)
{
    int sumMatSinh = default;
    int iter=0;
    if (matrix.GetLength(1)<matrix.GetLength(0)) iter=matrix.GetLength(1);
    else iter=matrix.GetLength(0);
    for (int i = 0; i < iter; i++)
    {
        sumMatSinh += matrix[i, i];
    }
    return sumMatSinh;
}

int[,] array2D = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
int result = SumMatrixSinh(array2D);
Console.WriteLine($"Сумма равна {result}");
