
Console.WriteLine("Введите первое число ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;


if (b > max)
{
    max = b;
}

else if (c > max)
{
    max = c ;
}

Console.WriteLine("Наибольшее число ");
Console.WriteLine(max);

