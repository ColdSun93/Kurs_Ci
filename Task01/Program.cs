// 9. Напишите программу, которая
// выводит случайное число из отрезка [10, 99] b
// показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = 88; //new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из диапозона 10-99 -> {num}");

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// if (firstDigit > secondDigit) Console.Write($"Наибольшая цифра числа = {firstDigit}");
// else Console.Write($"Наибольшая цифра числа = {num} = {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;

//int max = Math.Max(firstDigit, secondDigit);
//Console.Write($"Наибольшая цифра числа = {num} = {max}");


// int firstDigit = num / 10; // 78 / 10 = 7
// int secondDigit = num % 10; // 78 % 10 = 8

// int res = firstDigit;
// if (secondDigit > firstDigit) res = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {res}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

// Console.Write($"Наибольшая цифра числа {num} = ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);

// int MaxDigit(int number)
// {
//     int firstDigit = number / 10; // 78 / 10 = 7
//     int secondDigit = number % 10; // 78 % 10 = 8
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }

// int num = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

// int maxDigit = MaxDigit(num);
// Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");


