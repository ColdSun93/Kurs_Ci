// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumNumbersA(int num)
// {
//     int sum = 0;

//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число A");
// int numA = Convert.ToInt32(Console.ReadLine());

// int sumNumbersA = SumNumbersA(numA);
// Console.WriteLine($"Сумма чисел от 1 до {numA} = {sumNumbersA}");

//***********************************************************************************

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int CountNumbers(int number)
// {
//     int count = 0;

//     while (number != 0)
//     {
//         number = number / 10;
//         count++;
//     }


//     return count == 0 ? 1 : count;
// }


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int countNum = CountNumbers(num);
// Console.WriteLine($"Количество цифр в числе {num} = {countNum}");

//***********************************************************************************

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int ProductNum(int num)
// {
//     int prNum = 1;

//     for (int i = 1; i <= num; i++)
//     {
//         prNum *= i;
//     }
//     return prNum == 1 ? 0 : prNum;
// }
// Console.WriteLine("Введите число A");
// int numA = Convert.ToInt32(Console.ReadLine());

// int productNum = ProductNum(numA);
// Console.WriteLine($"Произведение чисел от 1 до {numA} = {productNum}");

//***********************************************************************************
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CompletionArr(int len)
{
    int[] arr = new int [len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {

        if (i != arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

 Console.WriteLine("Введите размер создаваемого массива");
 int size = Convert.ToInt32(Console.ReadLine());
int[] array = CompletionArr(size);
//int[] array = new int [size];
//CompletionArr(array);
WriteArr(array);
//0-7
//array[5] = 456;
// for (int i = 0; i < array.Length; i++)
// {
//     Array[i]=
// }

//***********************************************************************************
