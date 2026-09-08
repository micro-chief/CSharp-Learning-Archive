
using System;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("numbers.txt"))
        {
            for ( int i = 1; i <= 500; i++ )
            {
                writer.Write(i);
                if (i < 500)
                {
                    writer.Write(",");
                }
            }
        }
    }
}