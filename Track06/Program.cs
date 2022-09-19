Console.WriteLine("Домашнее задача № 2");

int Max(int arg1, int arg2) {
    int res = arg1;
    if(arg2 > res) res = arg2;
    return res;
}
int a1 = 5;
int b1 = 7;
int max1 = Max(a1,b1);
Console.WriteLine("Максимальное число : " + max1);

int a2 = 2;
int b2 = 10;
int max2 = Max(a2,b2);
Console.WriteLine("Максимальное число : " + max2);

int a3 = -9;
int b3 = -3;
int max3 = Max(a3,b3);
Console.WriteLine("Максимальное число : " + max3);




