// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
// массива.

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

// void ReplaceRows(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0)-1, i];
//         matrix[matrix.GetLength(0)-1, i] = temp;
//     }
// }

// int[,] array2D = CreateMatrixRndInt(4, 3, 1, 10);
// PrintMatrix(array2D);
// Console.WriteLine();
// ReplaceRows(array2D);
// PrintMatrix(array2D);

//**********************************************************************

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.


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

// int[,] ChangeMatrix(int[,] matrix)
// {
//     int[,] matr = new int[matrix.GetLength(0), matrix.GetLength(1)]; // 0, 1 

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = matrix[j, i];
//         }
//     }
//     return matr;
// }

// int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
// PrintMatrix(array2D);

// if (array2D.GetLength(1) == array2D.GetLength(0))
// {
//     int[,] array2DChange = ChangeMatrix(array2D);
//     Console.WriteLine();
//     PrintMatrix(array2DChange);
// }
// else Console.WriteLine("Замена строк на столбцы невозможна");


//**********************************************************************


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

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

// int[] MatrixToArray(int[,] matrix)
// {
//     int[] arr = new int[matrix.Length];
//     int k = default;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arr[k++] = matrix[i, j];
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i],3}, ");
//         else Console.Write($"{array[i],5}");
//     }
//     Console.WriteLine("]");
// }

// void Dictionary(int[] array)
// {
//     int num = array[0];
//     int count = 1;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (num == array[i]) count++;
//         else
//         {
//             Console.WriteLine($"Число {num} встречается {count} раз");
//             num = array[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"Число {num} встречается {count} раз");
// }



// int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
// PrintMatrix(array2D);
// Console.WriteLine();

// int[] arrayBib = MatrixToArray(array2D);
// PrintArray(arrayBib);

// Array.Sort(arrayBib);
// Console.WriteLine();
// PrintArray(arrayBib);
// Dictionary(arrayBib);


//**********************************************************************

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

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

int[] MinElemetMatrix(int[,] matrix)
{
    int[] arr = new int[2];
    int minElement = matrix[0, 0];
    int row = 0;
    int column = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column };
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i],3}, ");
        else Console.Write($"{array[i],5}");
    }
    Console.WriteLine("]");
}

int[,] RemoveColumnMin(int[,] matrix, int[] array)
{
    int[,] matrixTwo = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]; // 0, 1 
    int row = 0;
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        if (row == array[0]) row++;
        int column = 0;
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            if (column == array[1]) column++;
            matrixTwo[i, j] = matrix[row, column];
            column++;
        }
        row++;
    }
    return matrixTwo;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] arrayMinElemIndex = MinElemetMatrix(array2D);
PrintArray(arrayMinElemIndex);
int[,] array2DTwo = RemoveColumnMin(array2D, arrayMinElemIndex);
Console.WriteLine();
PrintMatrix(array2DTwo);