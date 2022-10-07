//Найти максимум 9 чисел

int Max( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result ;
}

int a1 = 100;
int b1 = 21 ;
int c1 = 99 ;
int a2 = 15 ;
int b2 = 23;
int c2 = 22 ;
int a3 = 34 ;
int b3 = 56;
int c3 = 99 ;

int max1 = Max(a1, b1, c1);
 int max2 = Max(a1, b1, c1);
int max3 = Max(a1, b1, c1);
int max = Max(max1, max2, max3);

Console.WriteLine(max);