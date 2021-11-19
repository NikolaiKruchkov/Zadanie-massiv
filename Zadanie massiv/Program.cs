using System;

namespace Zadanie_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] massiv = new double[7];
            int k = 1;
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите значение {0} элемента массива затем нажмите Enter", k);
                double n = Convert.ToDouble(Console.ReadLine());
                massiv[i] = n;
                k += 1;
                sum = sum + n;
            }

            Console.WriteLine("Среднее арифмитическое элементов массива равно {0, 4:f2}", sum / 7);
            Console.Write("Спасибо, что использовали нашу программу, для выхода нажмите любую клавишу");
            Console.ReadKey();









        }
    }
}
