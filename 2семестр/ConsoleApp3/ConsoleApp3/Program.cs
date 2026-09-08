int i, j, h, g;
double sum = 0, sum2 = 0, sum3 = 0, sum4 = 0, avg = 0, avg2 = 0, avg3 = 0, avg4 = 0, ogo = 0, ura = 0, p1 = 0, p2 = 0, sqrt = 0;
int n = Convert.ToInt32(Console.ReadLine());
int[,] p = new int[n, n], ara_ara = new int[n, n];
Random r = new Random();
for (i = 0; i < ara_ara.GetLength(0); i++)
{
    for (j = 0; j < ara_ara.GetLength(1); j++)
    {
        ara_ara[i, j] = r.Next(0, 9);
        Console.Write(ara_ara[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}
Console.WriteLine("\nДиагональ\n");


for (i = 0; i < ara_ara.GetLength(0); i++)
{
    Console.Write(ara_ara[i, i] + " ");
    sum += ara_ara[i, i];
    avg = sum / n;
}
Console.WriteLine("\nAvg: " + avg);
Console.WriteLine("\nдр.Диагональ\n");

for (i = 0, j = ara_ara.GetLength(0) - 1; j >= 0; j--, i++)
{
    Console.Write(ara_ara[i, j] + " ");
    sum2 += ara_ara[i, j];
    avg2 = sum2 / n;
}
Console.WriteLine("\nAvg2: " + avg2);

for (h = 0; h < p.GetLength(0); h++)
{
    for (g = 0; g < p.GetLength(1); g++)
    {
        p[h, g] = r.Next(0, 9);
        Console.Write(p[h, g].ToString().PadLeft(4));
    }
    Console.WriteLine();
}
Console.WriteLine("\nосн.Диагональ\n");

for (h = 0; h < p.GetLength(0); h++)
{
    Console.Write(p[h, h] + " ");
    sum3 += p[h, h];
    avg3 = sum3 / n;
}
Console.WriteLine("\nAvg3: " + avg3);
Console.WriteLine("\nдр.Диагональ\n");

for (h = 0, g = p.GetLength(0) - 1; g >= 0; g--, h++)
{
    Console.Write(p[h, g] + " ");
    sum4 += p[h, g];
    avg4 = sum4 / n;
}
Console.WriteLine("\nAvg4: " + avg4);

ogo = avg + avg2;
Console.WriteLine("\nСумма двух диагоналей: \n" + ogo);

ura = avg3 + avg4;
Console.WriteLine("\nСумма двух диагоналей: \n" + ura);


for (i = 0; i < ara_ara.GetLength(0); i++)
{
    for (j = 0; j < ara_ara.GetLength(1); j++)
    {
        if (ogo > ura)
        {
            Math.Pow(ogo, 2);
            ara_ara[i, j] *= 2;
            Console.Write(ara_ara[i, j].ToString().PadLeft(4));
        }
    }
    Console.WriteLine();
}

p1 = avg * avg2;
Console.WriteLine("\nПроизведение диагоналей:\n" + p1);

p2 = avg2 * avg4;
Console.WriteLine("\nПроизведение диагоналей:\n" + p2);


for (h = 0; h < p.GetLength(0); h++)
{
    for (g = 0; g < p.GetLength(1); g++)
    {
        
        if (p2 > p1)
        {
            sqrt = Math.Sqrt(p[g, h]);
        }
        Console.Write(p[h, g].ToString().PadLeft(4));
    }
    Console.WriteLine();

}
Console.WriteLine("\nэто_ж_наш_коренъ:\n" + sqrt);
