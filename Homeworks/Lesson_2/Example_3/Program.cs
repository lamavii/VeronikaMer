//Задача 15: Напишите метод, который принимает на вход цифру, 
//обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7 включительно");
int number = Convert.ToInt32(Console.ReadLine());

void DayNumber(int day)
{
if(day==6 ||day == 7)
{
    Console.WriteLine("Выходной");
}
else Console.WriteLine("Будний") ;
}

DayNumber(number);





