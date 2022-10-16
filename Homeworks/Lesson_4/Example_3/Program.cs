/*  Напишите метод, который задаёт массив из 8 элементов и выводит их на экран. */


int size = 0;
Console.Write("Введите длину массива");
size = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

int[] res = RandomArray(size);

PrintArray(res);