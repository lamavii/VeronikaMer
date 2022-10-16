/* Опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B. */

int num1 = 0;
Console.Write("Введите число целое положительное число А");
num1 = Convert.ToInt32(Console.ReadLine());

int num2=0;
Console.Write("Введите число целое положительное число B ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 >= 0 && num2 == 0)
{
    Console.WriteLine($"Число {num1} в степени {num2} -> 1");
    return;
}
if (num1 == 0 && num2 > 0)
{
    Console.WriteLine($"Число {num1} в степени {num2} -> 0");
    return;
}

int Pow(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}
int result = Pow(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} -> {result}");