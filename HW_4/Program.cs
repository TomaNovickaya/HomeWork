//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int step = 1;
while (step<=number)
{
  if (step%2==0)
    {
    Console.WriteLine(step); 
     
        }
       step=step+1;
  
}




 


               
    
 

