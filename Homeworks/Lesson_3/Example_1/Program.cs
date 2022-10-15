
int number = 0;
    Console.Write("Введите натуральное число");
    number = Convert.ToInt32(Console.ReadLine());
    
if (number < 10)
{
    Console.WriteLine($"Число {number} является палиндромом.");
    return;
}

string Palindrom(int num)
{
    int i = 0;
    int diff = num;
    do                                   
    {
        diff = diff / 10;
        i++;
    } while (diff > 0);
    int[] cifri = new int[i];            

    i = 0;
    do                                   
    {
        cifri[i] = num % 10;
        num = num / 10;
        i++;
    } while (num > 0);

    for (i = 0; (i < (cifri.Length / 2)); i++) 
    {
        if (cifri[i] != cifri[cifri.Length - (1 + i)]) 
        {
            return "не является палиндромом";
        }
    }
    return "является палиндромом";
}

Console.WriteLine($"Число {number} {Palindrom(number)}");