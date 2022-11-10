// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] GetSumPositiveNegativeElem(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPositive += array[i];
//         else sumNegative += array[i];
//     }
//     //int[] result = {sumPositive, sumNegative};
//     return new int[] { sumPositive, sumNegative };
// }

// Console.WriteLine("Введите массив");
// int[] arr = CreateArrayRndInt(12, -9, 9);
// // [0]-сумм+, [1]-сумма -
// PrintArray(arr);
// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");

//******************************************************

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// void SignChangeArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     //PrintArray(array);
// }

// Console.WriteLine("Введите массив");
// int[] arr = CreateArrayRndInt(4, -9, 9);
// PrintArray(arr);
// SignChangeArr(arr);
// PrintArray(arr);

//***************************************************************

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// bool SearchArr(int[] array, int find)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == find) return true;
//     }
//     return false;
// }

// int[] arr = CreateArrayRndInt(5, 0, 500);
// PrintArray(arr);
// Console.WriteLine("Введите искомый элементов");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = SearchArr(arr, num);
// Console.WriteLine(result ? "Да" : "Нет");

//***************************************************************
// Задача 35: Задайте одномерный массив из 123 случайных чисел.Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int CountNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ((array[i] >=10) && (array[i] <= 99)) count++;
//     }
//     return count;
// }
// int[] arr = CreateArrayRndInt(5, 0, 500);
// PrintArray(arr);
// int getCount = CountNum(arr);
// Console.Write($"Количество двухзначных чисел в массиве = {getCount}");



//***************************************************************
// Задача 37: Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] MultElemArray(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    //if (array.Length % 2 == 1) size = size + 1;
    int[] arrayTwo = new int[size];
    for (int i = 0; i < size; i++)
    {
        //if (i == array.Length-i) arrayTwo[i]=array[i];
        arrayTwo[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) arrayTwo[size - 1] = array[size - 1];

    return arrayTwo;
}
int[] arrOne = CreateArrayRndInt(5, 1, 10);
PrintArray(arrOne);
int[] arrTwo = MultElemArray(arrOne);
PrintArray(arrTwo);

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         double num = rnd.NextDouble() * (max - min) + min;
//         array[i] = Math.Round(num, 1);
//     }
//     return array;
// }
