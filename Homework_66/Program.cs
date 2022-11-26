// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120

int SumNaturalNumber(int numM, int numN) //5
{
    int sum = numM;
    if (numM == numN) return sum;
    else return sum = sum + SumNaturalNumber(numM + 1, numN);

}

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int result = 0;

if ((numberM < 0) || (numberN < 0)) Console.WriteLine("неверный ввод");
else if (numberM > numberN)
{
    result = SumNaturalNumber(numberN, numberM);
    Console.WriteLine($"сумму натуральных элементов в промежутке от {numberN} до {numberM} = {result}");
}
else
{
    result = SumNaturalNumber(numberM, numberN);
    Console.WriteLine($"сумму натуральных элементов в промежутке от {numberM} до {numberN} = {result}");
}
