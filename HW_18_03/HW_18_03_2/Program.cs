// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int[] arrey = new int [4] {1,2,3,4};
int sum=0;
 for (int i = 0; i < arrey.Length; i++)
 {
  
    sum=arrey[0]+arrey[1]+arrey[2]+arrey[3];
    Console.WriteLine($"Массив: {arrey[i]} Сумма: {sum}");
 }
