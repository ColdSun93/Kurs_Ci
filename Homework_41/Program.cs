// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] ReadArr(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{i + 1} число = "); // обозначение 0 элемента массива, для пользователя идет с 1
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountPositivNum(int[] arr)
{
    int countPosNum = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) countPosNum++;
    }
    return countPosNum++;
}


Console.WriteLine("Введите планируемое количество чисел");
int countNum = Convert.ToInt32(Console.ReadLine());
if (countNum > 0)
{
    int[] array = ReadArr(countNum);
    int result = CountPositivNum(array);
    Console.WriteLine($"Количество введенных чисел больших 0 = {result}");
    Console.Write("Можете проверить самостоятельно");
    WriteArr(array);
}
else Console.WriteLine("Неверный ввод");

