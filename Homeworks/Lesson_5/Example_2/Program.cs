/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] RandomArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100, 100);
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

int SumNeChet(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        count += arr[i];
    }
    return count;

}

int size = 0;
Console.Write("Введите длину массива");
size = Convert.ToInt32(Console.ReadLine());
int[] mass = RandomArray(size);
PrintArray(mass);
int res=SumNeChet(mass);
Console.WriteLine($" -> сумма нечетных элементов массива равна {res}");