// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Вариант 1

int[] arrey = new int[8];

for (int i = 0; i < arrey.Length; i++)
{
    int x= new Random().Next(0,100);
    arrey[i]=x;
   Console.Write($"{arrey[i]}   "); 
}

// Вариант 2
int[] arrey = new int[8] {1,2,3,4,5,6,7,8};

for (int i = 0; i < arrey.Length; i++)
{
      Console.Write($"{arrey[i]}   "); 
}
