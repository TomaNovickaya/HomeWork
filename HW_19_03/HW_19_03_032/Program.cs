int[] arr=new int [10];

void PrintArrey(int [] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        int x = new Random().Next(1,100);
        arrey[i]=x;
                Console.Write($"   {arrey[i]}");

            }
    Console.WriteLine();
   
}

 PrintArrey(arr);
int min =arr[0];
 for (int i = 0; i < arr.Length; i++)
 {
    if (arr[i]<min) min=arr[i];     
       
 }
 Console.WriteLine($"Минимальный элемент массива: {min}");
 
 int max =arr[0];
 for (int i = 0; i < arr.Length; i++)
 {
    if (arr[i]>max) max=arr[i];     
       
 }
 Console.WriteLine($"Максимальный элемент массива: {max}");

 int res= max-min;
 Console.WriteLine($"Разница между максимальным и минимальным: {res}");