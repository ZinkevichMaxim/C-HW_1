// task5 - (семинар1) - Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
if(x < 0)
{x = x * -1;}
int z = x * -1;
do {Console.WriteLine(z);
    z = z + 1;}
    while (z <= x);
