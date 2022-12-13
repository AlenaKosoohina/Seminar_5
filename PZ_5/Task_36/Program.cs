int[] array = new int[10];
int summ = 0;
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    array[i] = rnd.Next(-100,100);
    Console.Write($"{array[i]} ");
    if (i % 2 != 0)
    {
       summ=summ+array[i] ;
    }
}
Console.WriteLine();
Console.WriteLine(summ);