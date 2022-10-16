/*  Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе. */

int num1=0;
Console.Write("Введите целое положительное число");
    num1 = Convert.ToInt32(Console.ReadLine());

    int Sum(int num)
{
    int summa = 0;
    for (int i = 0; num > 0; i++)
    {
        summa = summa + (num % 10);
        num = num / 10;
    }
    return summa;
}

int result = Sum(num1);
Console.WriteLine($"Сумма цифр числа {num1} равна {result}");

