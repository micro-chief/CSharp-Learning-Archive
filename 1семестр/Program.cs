int n = Convert.ToInt32(Console.ReadLine());
double sum = 0, sum2 = 0, avg = 0, avg2 = 0, sumMas = 0, umnozh = 0;
int[,] p = new int[n, n];
Random r = new Random();
for (int i = 0; i < p.GetLength(0); i++)
{
    for (int j = 0;  j < p.GetLength(1); j++)
    {
        p[i, j] = r.Next(0, 9);
        Console.Write(p[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}
Console.WriteLine("osnovnaya diagon: ");
for (int i = 0; i < p.GetLength(0); i++)
{
    Console.Write(p[i,i] + " ");
    sum += p[i, i];
    avg = sum / n;
}
Console.WriteLine("avg arifm osn: " + avg);
for (int i = 0, j=p.GetLength(0) - 1; j >= 0; j--, i++)
{
    Console.Write(p[i, j] + " ");
    sum2 += p[i, j];
    avg2 = sum2 / n;
}
Console.WriteLine("avg arifm drug: " + avg2);
for (int i = 0; i < p.GetLength(0); i++)
{
    for (int j = 0; j < p.GetLength(1); j++)
    {
        if (avg > avg2)
        {
            p[i, j] *= 2;

        }
        else
        {
            p[i, j] *= 3;
        }
        Console.Write(p[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
    
}
sumMas = avg + avg2;
Console.WriteLine("sum Messi: " +  sumMas);
umnozh += avg * avg2;
Console.WriteLine("unmnozhil Messi: " + umnozh);
for (int i = 0; i < p.GetLength(0);i++)
{
    for (int j = 0; j < p.GetLength(1); j++)
    {
        if (sum > sum2)
        {
            sum += sum2 * sum2;
            p[i, j] *= 2;
        }
        Console.WriteLine(p[i,j].ToString().PadLeft(4));
    }
    Console.WriteLine();

}
for (int i = 0; i < p.GetLength(0);i++)
{

}