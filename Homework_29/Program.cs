// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] ReadArr(int len)
{
    int[] arr = new int[len];
    //Random rnd = new Random();            //для автоматического заполнения массива
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{i + 1} элемент массива = "); // обозначение 0 элемента массива, для пользователя идет с 1
        //arr[i] = rnd.Next(0, 100);        //для автоматического заполнения массива
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

Console.WriteLine("Введите массив из 8 элементов");

int[] array = ReadArr(8);
//int[] array = {1, 2, 5, 7, 19, 6, 1, 33};     

WriteArr(array);