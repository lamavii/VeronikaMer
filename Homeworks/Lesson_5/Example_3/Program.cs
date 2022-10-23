/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] RandomArray(int length, int maxim, int minim)
{
    Random rnd = new Random();
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (maxim - minim) + minim), 1, MidpointRounding.ToZero);
    }
    return array;

}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

double Diff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    double result = Math.Round((max - min), 1, MidpointRounding.ToZero);
    return result;
}
int size = 0;
 Console.Write("Введите длину массива");
  size = Convert.ToInt32(Console.ReadLine());
 double[] mass = RandomArray(size, 0, 100);
PrintArray(mass);
double res = Diff(mass);
Console.WriteLine($" -> разница между максимальным и минимальным элементом составляет {res}");