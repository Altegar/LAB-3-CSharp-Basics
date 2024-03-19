// Сушинський Ігор
// Лабораторна робота № 3
// Функції, що містять цикли.
// Варіант 3

namespace LAB_3_CSharp
{
    internal class Program
    {
        private static double f1(int N)
        {
            double S = 0;
            int i = 1;
            while (i <= N)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
                i++;
            }
            return S;
        }

        private static double f2(int N)
        {
            double S = 0;
            int i = 1;
            do
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
                i++;
            } while (i <= N);
            return S;
        }

        private static double f3(int N)
        {
            double S = 0;
            for (int i = 1; i <= N; i++)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
            }
            return S;
        }

        private static double f4(int N)
        {
            double S = 0;
            for (int i = N; i >= 1; i--)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
            }
            return S;
        }

        private static void g1(int N, ref double y)
        {
            double S = 0;
            int i = 1;
            while (i <= N)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
                i++;
            }
            y = S;
        }

        private static void g2(int N, ref double y)
        {
            double S = 0;
            int i = 1;
            do
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
                i++;
            } while (i <= N);
            y = S;
        }

        private static void g3(int N, ref double y)
        {
            double S = 0;
            for (int i = 1; i <= N; i++)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
            }
            y = S;
        }

        private static void g4(int N, ref double y)
        {
            double S = 0;
            for (int i = N; i >= 1; i--)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
            }
            y = S;
        }

        private static void h1(int N, out double y)
        {
            double S = 0;
            int i = 1;
            while (i <= N)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
                i++;
            }
            y = S;
        }

        private static void h2(int N, out double y)
        {
            double S = 0;
            int i = 1;
            do
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
                i++;
            } while (i <= N);
            y = S;
        }

        private static void h3(int N, out double y)
        {
            double S = 0;
            for (int i = 1; i <= N; i++)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
            }
            y = S;
        }

        private static void h4(int N, out double y)
        {
            double S = 0;
            for (int i = N; i >= 1; i--)
            {
                S += (1 / i) + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));
            }
            y = S;
        }

        private static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // перший спосіб - інформацію отримуємо як результат функції
            Console.WriteLine($"S = {f1(N)}");
            Console.WriteLine($"S = {f2(N)}");
            Console.WriteLine($"S = {f3(N)}");
            Console.WriteLine($"S = {f4(N)}");
            Console.WriteLine();

            // другий спосіб - інформацію отримуємо як параметр-посилання
            double y1 = 0, y2 = 0, y3 = 0, y4 = 0;

            g1(N, ref y1);
            g2(N, ref y2);
            g3(N, ref y3);
            g4(N, ref y4);

            Console.WriteLine($"S = {y1}");
            Console.WriteLine($"S = {y2}");
            Console.WriteLine($"S = {y3}");
            Console.WriteLine($"S = {y4}");
            Console.WriteLine();

            // третій спосіб - інформацію отримуємо як вихідний параметр
            double z1, z2, z3, z4;

            h1(N, out z1);
            h2(N, out z2);
            h3(N, out z3);
            h4(N, out z4);

            Console.WriteLine($"S = {z1}");
            Console.WriteLine($"S = {z2}");
            Console.WriteLine($"S = {z3}");
            Console.WriteLine($"S = {z4}");
            Console.WriteLine();
        }
    }
}