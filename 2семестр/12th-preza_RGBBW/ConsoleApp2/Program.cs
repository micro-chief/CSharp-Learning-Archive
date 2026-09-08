using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "green", "black", "white", "blue" };
            using (StreamWriter writer = new StreamWriter("colors.txt"))
            {
                foreach (string color in colors)
                {
                    writer.WriteLine(color);
                }
            }
        }
    }
}