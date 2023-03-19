// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
    if(i%2!=0)
    {
       t+=arr[i];
         Console.WriteLine($"Элементы на нечетных позициях : {arr[i]}");
         
    }

}
Console.WriteLine($"Сумма элементов на нечетных позициях: {t}");