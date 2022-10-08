//Задача 13: Напишите метод, который выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdNumber ( int num )
{
    if (num >= 100)
    {
      Console.WriteLine(num% 10);
    }
    else if (num < 100)
    {
        Console.WriteLine("Нет цифры");
    }  return num;
}

ThirdNumber(number);


