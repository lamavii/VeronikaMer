
int number = 0;

    Console.Write("Введите натуральное число больше единицы");
    number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("  N  |  N^3  ");

for (int i = 1; i <= number; i++)
{
        Console.Write($"{i,3}  |");
        Console.WriteLine($"  {i * i * i, 3}");
}