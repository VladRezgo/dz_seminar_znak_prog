

//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int n = 1;
 while (n <= num) 
{
   if (n %2 > 0)
   {
      n = n + 1;
   }
      else 
      {
         Console.WriteLine("{0} четное число", (n));
         n = n+1;
      }
      
}

 


 

  
