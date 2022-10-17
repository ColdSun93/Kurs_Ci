// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {num}");

// int FunTwo(int numC)
// {
//     int firstDigit = numC / 100;
//     int threeDigit = numC % 10;
//     return firstDigit * 10 + threeDigit;
// }

// Console.WriteLine($"{FunTwo(num)}");

//***********************************************************

// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int Ostatok(int number1, int number2)
// {
//      return number1 % number2;
// }

// int numA = Convert.ToInt32(Console.ReadLine());
// int numB = Convert.ToInt32(Console.ReadLine());

// if (Ostatok(numA, numB) == 0) Console.WriteLine($"число {numA} кратно {numB}");
// else Console.WriteLine($"число {numA} не кратно {numB}, остаток {Ostatok(numA, numB)}");

//**********************************************************************************************

// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// bool Chet(int number1)
// {
//     return (number1 % 7 == 0) && (number1 % 23 == 0);
// }
// int numA = Convert.ToInt32(Console.ReadLine());
// if (Chet(numA)) Console.WriteLine($"число кратно 7 и 23");
// else Console.WriteLine($"число не кратно 7 и 23");

//Console.WriteLine(Number(num1): "кратное"? "не кратно");

//**********************************************************************************************

// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool Square(int number1, int number2)
{
    return number1 * number1 == number2;
}

int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
bool ressq = Square(numA, numB) || Square(numB, numA);
Console.WriteLine(ressq? "Да" : "Нет");