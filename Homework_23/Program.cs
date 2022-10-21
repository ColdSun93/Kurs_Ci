// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int n1)
{
    int count = 1;
    while (count <= n1)
    {
        Console.WriteLine($"|{count,4} | {Math.Pow(count, 3),4}|");
        count++;
    }
}

Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0) Table(n);
else Console.WriteLine("Некорректное значение");