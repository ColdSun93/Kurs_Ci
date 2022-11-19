// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int[] ReadArr(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{i + 1} элемент = ");       // обозначение 0 элемента массива, для пользователя идет с 1
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

Console.WriteLine("Введите позицию элемента двумерного массива, 1 - строка, 2 - столбец");
int[] coordinateElementArr = ReadArr(2);

int rowsMatrix = 7;                                 // задаем число строк массива
int columnsMatrix = 10;                             // задаем число столбцов массива
int[,] array2D = CreateMatrixRndInt(rowsMatrix, columnsMatrix, -100, 100);

if ((array2D.GetLength(0) > coordinateElementArr[0]-1) && (array2D.GetLength(1) > coordinateElementArr[1]-1)) 
{
    int result = array2D[coordinateElementArr[0]-1, coordinateElementArr[1]-1];
    Console.WriteLine($"Искомый элемент = {result}");
}
 else Console.WriteLine("Такой элемент в массиве отсутствует");

PrintMatrix(array2D);       //для проверки