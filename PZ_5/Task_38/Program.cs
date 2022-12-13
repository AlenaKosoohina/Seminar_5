double[] array = new double[10];
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    array[i] = Math.Round(rnd.NextDouble()+rnd.Next(11),2);
    Console.Write($"{array[i]} ");
}
double min = array[0];
double max = array[0];
for (int i = 1; i < 10; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else
    {
        if (array[i] > max)
        {
            max= array[i];  
        }
    }

}

Console.WriteLine();
Console.WriteLine(Math.Round((max-min),2));