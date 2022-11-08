// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CompletionArr(int len)
{
    int[] arr = new int [len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next();
    }
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {

        if (i != arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

 Console.WriteLine("Введите размер создаваемого массива");
 int size = Convert.ToInt32(Console.ReadLine());
int[] array = CompletionArr(size);
//int[] array = new int [size];
//CompletionArr(array);
WriteArr(array);