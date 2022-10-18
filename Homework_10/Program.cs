// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondOfThree(int number1)
{
        return number1 / 10 % 10;
}

Console.WriteLine("Введите трехзначное число");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA<0) numA=numA*(-1);
if ((numA > 99) && (numA < 1000)) Console.WriteLine($"Вторая цифра из числа: {SecondOfThree(numA)}");
else Console.WriteLine("Неверное число");