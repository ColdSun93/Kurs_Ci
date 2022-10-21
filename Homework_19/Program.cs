// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int number1)
{
    int number2 = 0;
    int numOst = number1;
    while (numOst != 0)
    {
        number2 = number2 * 10 + numOst % 10; ;
        numOst = numOst / 10;
    }
    return (number1 == number2);
}

Console.WriteLine("Введите пятизначное число");
int numA = Convert.ToInt32(Console.ReadLine());
int modulNum = Math.Abs(numA);
string result;

if ((modulNum > 9999) && (modulNum < 100000))   //если убрать условие то работает со всеми числами в диапозоне int
{
    result = Palindrome(modulNum)
                ? $"Число {numA} полиндром"
                : $"Число {numA} не полиндром";
}
else result = "Число не пятизначное";

Console.WriteLine(result);
