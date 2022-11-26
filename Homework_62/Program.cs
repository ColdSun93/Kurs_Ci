// Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void CreateMattree(int[,] matrix, int rows, int columns, int min)
{
    int i = 0;
    int j = 0;
    int leftColums = 0;
    int topRows = 0;
    int countElementArr = rows * columns;
    while (min <= countElementArr)
    {
        matrix[i, j] = min;

        if ((i == topRows) && (j < columns - 1)) j++;
        else if ((j == columns - 1) && (i < rows - 1)) i++;
        else if ((i == rows - 1) && (j > leftColums)) j--;
        else if ((j == leftColums) && (i > leftColums)) i--;

        if ((i == topRows) && (j == leftColums) && (matrix[i, j] != 0))
        {
            topRows++;
            leftColums++;
            columns--;
            rows--;
            i++;
            j++;
        }
        min++;
    }
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

    int[,] array2D = new int[7, 7];
    CreateMattree(array2D, 7, 7, 1);
    PrintMatrix(array2D);