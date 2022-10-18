// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdOfNum(int number1)
{
    while (number1 > 1000)
    {
        number1 = number1 / 10;
    }
    return number1 % 10;
}

Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA < 0) numA = numA * (-1);
if (numA > 99) Console.WriteLine($"Третья цифра из числа: {ThirdOfNum(numA)}");
else Console.WriteLine("Третьей цифры нет");