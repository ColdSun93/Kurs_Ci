// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void NaturalNumber(int num) //5
// {
//     if (num == 0) return;

//     NaturalNumber(num - 1);
//     Console.Write($"{num} ");
// }


// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(number);

//********************************************************************

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// void NaturalNumber(int numM, int numN) //5
// {
//     if (numM < numN)
//     {
//         Console.Write($"{numM} ");
//         NaturalNumber(numM + 1, numN);
//     }
//     if (numM > numN)
//     {
//         Console.Write($"{numM} ");
//         NaturalNumber(numM - 1, numN);
//     }
//     if(numM==numN) Console.Write($"{numM} ");
// }


// Console.WriteLine("Введите натуральное число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(numberM, numberN);

//**********************************************************************

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumNumber(int num)
// {
//     int sum = num % 10;
//     if (num == 0) return 0;
//     else return sum + SumNumber(num / 10);
// }

// Console.WriteLine("Введите натуральное число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// int result = SumNumber(numberN);
// Console.WriteLine($"Сумма цифр числа {numberN} = {result} ");



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DegreeNumber(int numA, int numB)
 {
     if (numB == 0) return 1;
     else return numA*DegreeNumber(numA, numB-1);
 }

Console.WriteLine("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB>=0)
{
int result = DegreeNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {result} ");
}
else Console.WriteLine($"Неверное значение 2-го числа");