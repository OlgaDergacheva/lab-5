using System;
using System.IO;
namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {


            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int[N, M];
            /*
            // 1 задание через заполение
            Console.WriteLine(" Elementary matrix ");
            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            // 1 задание через рандом
            Console.WriteLine(" Elementary matrix ");

            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = rand.Next(-1000, 1000);
                    Console.Write(mas[i, j] + " "); ;
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            

            // 2 задание
            Console.WriteLine(" Sum of line elements ");

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    sum += mas[i, j];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.WriteLine();
            // 3 задание
            Console.WriteLine(" Last матрица ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] > 0) Console.Write(" + ");
                    else Console.Write(" - ");
                }
                Console.WriteLine();
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
