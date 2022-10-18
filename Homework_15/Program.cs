// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Day(int number1)
 {
     return (number1 == 6) || (number1 == 7);
}

Console.WriteLine("Введите день недели, в формате числа");
int numA = Convert.ToInt32(Console.ReadLine());

if ((numA > 0)&&(numA < 8)) Console.WriteLine(Day(numA)? "Выходной": "Будние");
else Console.WriteLine("Нет такого дня недели");
