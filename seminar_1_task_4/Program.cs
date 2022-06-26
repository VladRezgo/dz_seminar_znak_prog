//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;


if (max < b)
{
    max = b;
}   
if (max < c) 
{
    max = c;
}
        
Console.WriteLine("{0} Максимальное число", (max));
