int[] array = new int[10];
int k = 0;
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    array[i] = rnd.Next(100, 999);
    //Console.Write($"{array[i]} ");
    if (array[i]%2==0)
    {
        k++;    }
}
//Console.WriteLine();
Console.WriteLine(k);