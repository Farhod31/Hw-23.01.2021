using System;


namespace Lesson_2
{
    class Program
    {
        static void Main()
        {
            // Задания 2

            int A = 1, B = 10, sum = 0;

            for (int i = A + 1; i < B; i++)
            {
                {
                    sum += i;

                }
                Console.WriteLine(sum);

            }

            int C = 1, M = 10, Sum = 0;

            for (int i = A + 1; i < B; i++)

            {
                if (i % 2 == 1) ;
                {
                    Console.WriteLine(i);
                }
            }



            //Задания 3

            for (int i = 0; i < 5; i++)
            {
                if (i == 0 || i == 4)
                {
                    for (int j = 0; j < 10; j++)
                        Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    for (int k = 1; k < 9; k++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            // 90d triangle
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0 || j == i || i == 9)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            // 60d triangle
            var tx = 9;
            var ty = 9;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < (10 * 2) - 1; j++)
                {
                    if (j == tx || j == ty || i == 9)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                tx--;
                ty++;
                Console.Write("\n");
            }
            Console.WriteLine();
            // rhombus
            for (int i = 9; i >= -9; i--)
            {
                for (int j = 1; j <= Math.Abs(i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 9; k >= Math.Abs(i); k--)
                {
                    if (k == 9 || k == Math.Abs(i))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine();


            //Задания 4

            double dep = 1000;
            double per = Convert.ToDouble(Console.ReadLine());
            int mes = 0;
            while (dep <= 1100)
            {
                mes++;
                dep = dep * (per / 100 + 1);
            }
            Console.WriteLine("количество месяцев ");
            Console.WriteLine("итоговый размер вклада ");
            Console.ReadKey();


            //Дз 2
            //задания 2

            Console.Write("N = ");
            int.TryParse(Console.ReadLine(), out var N);
            var arr = new int[N];
            Random r = new Random();
            for (var i = 0; i < N; i++)
            {
                arr[i] = r.Next(1, 99);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            var mx = arr[0];
            var mn = arr[0];
            var sum1 = arr[0];
            for (int i = 1; i < N; i++)
            {
                mx = Math.Max(arr[i], mx);
                mn = Math.Min(arr[i], mn);
                sum1 += arr[i];
            }
            Console.WriteLine($"max = {mx}");
            Console.WriteLine($"min = {mn}");
            Console.WriteLine($"sum = {sum1}");
            Console.WriteLine($"average = {sum1 / N}");
            for (int i = 0; i < N; i++)
                if (arr[i] % 2 != 0)
                    Console.Write($"{arr[i]} ");

           // Задания 3

            Console.Write("elements: ");
            var elements = Console.ReadLine().Split(' ');
            var arr2 = new int[elements.Length];
            var invertedArr2 = new int[elements.Length];
            for (int f = 0; f < elements.Length; f++)
                arr2[f] = int.Parse(elements[f]);
            for (int i = 0; i < elements.Length; i++)
                invertedArr2[i] = arr2[(elements.Length - 1) - i];
            for (int v = 0; v < invertedArr2.Length; v++)
                Console.Write($"{invertedArr2[v]} ");


            //Задания 4

            int.TryParse(Console.ReadLine(), out var N2);
            var arrm1 = new int[N2];
            for (var i = 0; i < N2; i++)
            {
                arrm1[i] = r.Next(1, 99);
                Console.Write($"{arrm1[i]} ");
            }
            Console.WriteLine();
            Console.Write("count = ");
            int.TryParse(Console.ReadLine(), out var count);
            Console.Write("(starts from 0) index = ");
            int.TryParse(Console.ReadLine(), out var index);
            var arrm2 = new int[count];
            for (int i = 0; i < count; i++)
            {
                arrm2[i] = (index > arrm1.Length - 1) ? 1 : arrm1[index++];
                Console.Write($"{arrm2[i]} ");
            }
        }
    }
}

