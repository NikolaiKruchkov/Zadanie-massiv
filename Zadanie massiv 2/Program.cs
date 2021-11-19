using System;

namespace Zadanie_massiv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N затем нажмите Enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] massiv = new int[n, n];
            
            for (int i = 0; i < n; i+=2)
            {
                
                for (int j = 0; j < n; j+=2)
                {
                    massiv[i, j] = 1;                       
                               
                 }
                for (int j = 1; j < n; j += 2)
                {
                    massiv[i, j] = 0;

                }

            }
            for (int i = 1; i < n; i += 2)
            {

                for (int j = 0; j < n; j += 2)
                {
                    massiv[i, j] = 0;

                }
                for (int j = 1; j < n; j += 2)
                {
                    massiv[i, j] = 1;

                }
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}", massiv[i, j]);

                }
                Console.WriteLine();
            }


            Console.Write("Спасибо, что использовали нашу программу, для выхода нажмите любую клавишу");
            Console.ReadKey();



        }


    }

}
