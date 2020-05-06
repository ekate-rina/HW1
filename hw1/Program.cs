using System;

namespace HomeTask1
{
    /// <summary>
    /// Необходимо написать программу эмулирующую защиту выпускных работ. В комиссии присуствуют n экспертов.
    /// Ваша программа получает строку тему доклада, затем n оценок доклада и выводит среднюю оценку доклада.
    /// Считывание докладов и подсчет оценок происходит до тех пор, пока не получите команду "Finish". После
    /// данной комманды выводит средний показатель всех докладов. 
    /// </summary>
    class Program
    {
        
        private static void Main()
        {
            Console.WriteLine("Введите название доклада");
            string title = Console.ReadLine();
            double totalMark = 0;
            while (title != "Finish")
            {
                Console.WriteLine("Введите количество оценок");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i=0; i<n; i++)
                {
                    Console.WriteLine("Проставте свою оценку");
                    double mark = Convert.ToDouble(Console.ReadLine());
                    totalMark = totalMark + mark;
                }
                Console.WriteLine($"Средняя оценка {title}  - {totalMark /n}!");

                title = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
