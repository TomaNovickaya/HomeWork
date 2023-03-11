// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
           
          int x=number%10;
          int x1=number/10%10;

while (number>99 && number<=999)
{
    Console.WriteLine($"Число = {number}, Третий элемент = {x}");
    break;
}

    if(number>999)
    {
    Console.WriteLine($"Число = {number}, Третий элемент = {x=number/10%10}");
    }
    else
    {
        if (number<100)
        {
    Console.WriteLine($"Третьего элемента нет"); 
        }
    }

