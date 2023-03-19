// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr=new int [10];
//int count=0;
int t=0;
void PrintArrey(int [] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        int x = new Random().Next(100,1000);
        arrey[i]=x;
                Console.Write($"   {arrey[i]}");

            }
    Console.WriteLine();
   
}

 PrintArrey(arr);

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2==0)
    {
       t=t+1;
         Console.WriteLine($"Четное число: {arr[i]}");
         
    }

}
Console.WriteLine($"Количеств четных чисел: {t}");