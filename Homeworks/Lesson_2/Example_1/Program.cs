//Задача 10: Напишите метод, который принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");

 int number = Convert.ToInt32(Console.ReadLine()) ;

int SecondCount(int num)
{

return num / 10 % 10 ;

}

Console.WriteLine(SecondCount(number));


