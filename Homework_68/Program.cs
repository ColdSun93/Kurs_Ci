// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunk(int numM, int numN) //5
{
    if (numM == 0) return numN + 1;
    else if ((numM > 0) && (numN == 0)) return AkkermanFunk(numM - 1, 1);
    else return AkkermanFunk(numM - 1, AkkermanFunk(numM, numN - 1));

}

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = 0;

if ((numberM < 0) || (numberN < 0)) Console.WriteLine("Неверный ввод");
else
{
    result = AkkermanFunk(numberM, numberN);
    Console.WriteLine($"Функция Аккермана равна: {result}");
}