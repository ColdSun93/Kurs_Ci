// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double DegNum(int num, int deg)
{
    double prNum = 1;
    int count = Math.Abs(deg);

    for (int i = 1; i <= count; i++)
    {
        prNum *= num;
    }
    if (deg < 0)
    {
        return Math.Round(1 / prNum, 5, MidpointRounding.ToZero);
        //prNum = 1 / prNum;
        //return Math.Round(prNum, 2, MidpointRounding.ToZero);
    }
    else return prNum;
}
Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

double degNum = DegNum(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = {degNum}");
