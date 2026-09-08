using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace text_in_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите полное имя файл (например file.txt): ");
            string filename = @"D:\" + Console.ReadLine();
            if (File.Exists(filename))
            {
                Console.WriteLine("Файл " + filename + " открыт");
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            else
            {
                Console.WriteLine("Файл не существует");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Выбирите действие" + "\n" + "Закрыть - 1" + "\n" + "Редактировать - 2");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Вы завершили работу программы");
                    break;
                case 2:
                    Console.WriteLine("Вы перешли к редактированию файла");
                    FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                    StreamWriter sr = new StreamWriter(fs);
                    sr.WriteLine(Console.ReadLine());
                    sr.Close();
                    fs.Close();
                    Console.WriteLine("Успешное редактирование");
                    break;
            }
            Console.ReadKey();
        }
    }
}