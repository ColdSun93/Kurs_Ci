// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixProd = new int[matrixA.GetLength(0), matrixB.GetLength(1)]; // 0, 1 
    for (int i = 0; i < matrixProd.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProd.GetLength(1); j++)
        {
            int sumProduct = default;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sumProduct = matrixA[i, k] * matrixB[k, j] + sumProduct;
            }
            matrixProd[i, j] = sumProduct;
        }
    }
    return matrixProd;

}

int[,] array2dA = CreateMatrixRndInt(4, 3, 1, 10);
int[,] array2dB = CreateMatrixRndInt(3, 5, 1, 10);

PrintMatrix(array2dA);
Console.WriteLine();
PrintMatrix(array2dB);
Console.WriteLine();

if (array2dA.GetLength(1) == array2dB.GetLength(0))
{
    int[,] array2dProduct = MatrixProduct(array2dA, array2dB);
    Console.WriteLine("Произведение матриц равно:");
    PrintMatrix(array2dProduct);
}
else Console.WriteLine("Умножение матриц невозможно");
