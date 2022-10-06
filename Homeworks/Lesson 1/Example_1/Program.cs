Console.WriteLine("Введите первое число ");

int a = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Введите второе число ");

int b= Convert.ToInt32(Console.ReadLine()) ;

 bool Sit0 = a > b;
bool Sit1 = a == b;
bool Sit2 = a < b;
 
if (Sit0)
    {
        Console.WriteLine(" Наибольшее число ");
        Console.WriteLine(a);
            }
     else if (Sit1)
      {
                Console.WriteLine("Числа равны");
            }
     else
        {
                Console.WriteLine(" Наибольшее число " );
                Console.WriteLine(b);
            }



