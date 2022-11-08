// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int number)
{
    int sum = 0;
    int numF = number;

    while (numF != 0)
    {
        sum += numF % 10;
        numF /= 10;
    }
    return sum == 0 ? number : sum;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumNum = SumNumbers(num);

Console.WriteLine($"Cумма цифр в числе {num} = {sumNum}");