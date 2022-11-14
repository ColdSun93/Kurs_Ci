// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

// void ReversArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }


// int[] arrOne = CreateArrayRndInt(5, 1, 10);
// PrintArray(arrOne);
// ReversArray(arrOne);
// PrintArray(arrOne);

//********************************************************************

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
// такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// bool TriangleSearch(int one, int two, int three)
// {
//     int[] arr = {one, two, three};
//     bool[] arrTwo = new bool[3];
//     arrTwo[0] = one < arr[1] + arr[2];
//     arrTwo[1] = two < arr[0] + arr[2];
//     arrTwo[2] = three < arr[0] + arr[1];
//     return arrTwo[0] && arrTwo[1] && arrTwo[2];
// }

// Console.WriteLine("Введите первое число");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int numC = Convert.ToInt32(Console.ReadLine());

// bool result = TriangleSearch(numA, numB, numC);

// Console.WriteLine(result ? $"Да. Существует треугольник со сторонами {numA},{numB},{numC}." 
//                     : $"Нет. Не существует треугольник со сторонами {numA},{numB},{numC}.");


//********************************************************************

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int BinaryFun(int dec)
// {
//     if (dec == 0) return 0;
//     if (dec == 1) return 1;
//     return BinaryFun(dec / 2) * 10 + dec % 2;
// }

// Console.WriteLine("Введите  число");
// int numA = Convert.ToInt32(Console.ReadLine());
// int result = BinaryFun(numA);
// Console.WriteLine($"Десятичное число {numA} будет в двоичном представлении выглядеть как: {result}.");



// string ConvertDecToBinary(int dec)
// {
//     string binary = string.Empty;
//     while (dec>0)
//     {
//         binary = Convert.ToString(dec % 2) + binary;
//         dec /= 2;
//     }
//     return binary;
// }

// Console.Write ("Введите десятичное число: ");
// int numberDec = Convert.ToInt32(Console.ReadLine());
// string numberBinary = ConvertDecToBinary(numberDec);
// Console.WriteLine($"Десятичное число {numberDec} будет в двоичном представлении выглядеть как: {numberBinary}.");

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int number)
// {
//     int binNumber = 0;
//     int d10 = 1;
//     while (number > 0)
//     {
//         binNumber = binNumber + number % 2 * d10;
//         number /= 2;
//         d10 *= 10;
//     }
//     return binNumber;
// }

// int decToBin = DecToBin(num);

// Console.WriteLine($"Число {num} в двоичной системе = {decToBin}");

// string СonverterDigit(int num)
// {
//     string res = "";
//     while (num > 0)
//     {
//         res = $"{(num % 2)}{res}";
//         num /= 2;
//     }
//     return res;
// }


// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(СonverterDigit(a));

//********************************************************************

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void PrintArray(int[] array)
// {
//     //Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     //Console.WriteLine("]");
// }

// int[] RowArrayFibonachi(int size)
// {
//     int[] array = new int[size];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < size; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// Console.WriteLine("Введите число N");
// int numN = Convert.ToInt32(Console.ReadLine());
// int[] arr = RowArrayFibonachi(numN);
// PrintArray(arr);


//********************************************************************
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
// копирования.

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

int[] CreateArrayCopy(int[] array)
{
    int[] arrayTwo = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayTwo[i] = array[i];
    }
    return arrayTwo;
}

Console.WriteLine("Введите размер массив");
int sizeArr = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(sizeArr, -100, 100);
PrintArray(arr);
int[] arrTwo = CreateArrayCopy(arr);
PrintArray(arrTwo);

//********************************************************************
