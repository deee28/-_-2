using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1) " + "{0}", n * n / 2);

            Console.Write("k1= ");
            float k1 = float.Parse(Console.ReadLine());
            Console.Write("m1= ");
            float m1 = float.Parse(Console.ReadLine());
            float l1 = (m1 + k1) % 2;
            if (l1 != 0) Console.WriteLine("2) Черная");
            else Console.WriteLine("2) Белая");

            Console.Write("k2= ");
            float k2 = float.Parse(Console.ReadLine());
            Console.Write("m2= ");
            float m2 = float.Parse(Console.ReadLine());
            float l2 = (m2 + k2) % 2;
            if (l2 != 0) Console.WriteLine("2) Черная");
            else Console.WriteLine("2) Белая");

            if (l1 != l2) Console.WriteLine("3) Разного цвета");
            else Console.WriteLine("2) Одного цвета");

            if ((k1 == k2) && (m2 - m1 == 1)) Console.WriteLine("пешка ударит");
            else Console.WriteLine("пешка нет");

            if ((Math.Abs(k1 - k2)) == Math.Abs((m2 - m1))) Console.WriteLine("слон ударит");
            else Console.WriteLine("слон нет");

            if ((k1 == k2) || (m1 == m2)) Console.WriteLine("ладья ударит");
            else Console.WriteLine("ладья нет");

            if (((Math.Abs(k1 - k2)) == Math.Abs((m2 - m1))) || ((k1 == k2) || (m1 == m2))) Console.WriteLine("ферзь ударит");
            else Console.WriteLine("ферзь нет");

            if (((m2 + 3 == m1) || (m2 - 3 == m1) || (m2 + 1 == m1) || (m2 - 1 == m1)) && ((k2 + 3 == k1) || (k2 - 3 == k1) || (k2 + 1 == k1) || (k2 - 1 == k1))) Console.WriteLine("конь ударит");
            else Console.WriteLine("конь нет");

            //Console.WriteLine(">Введите дату в формате dd.mm.yyyy:");
            //DateTime dt = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(">Дней прошло с начала года:" + dt.DayOfYear);
            //DateTime now = DateTime.Now;
            //int nextYear = now.Year + 1;
            //DateTime nextNewYear = new DateTime(nextYear, 1, 1);
            //nextNewYear = new DateTime(nextNewYear.Ticks - 1);
            //int days = nextNewYear.DayOfYear - now.DayOfYear;
            //Console.WriteLine(">Дней осталось до конца года:" + days);
            //Console.WriteLine(">Дата предыдущего дня:" + dt.AddDays(-1).ToShortDateString());
            //Console.WriteLine(">Дата следующего дня:" + dt.AddDays(+1).ToShortDateString());

            //int n = 9;
            //for (int a = 1; a <= n; a++)
            //{
            //    for (int b = 0; b <= n; b++)
            //    {
            //        for (int c = 0; c <= n; c++)
            //        {
            //            if ((a * a * a + b * b * b + c * c * c) == (a * 100 + b * 10 + c))
            //                Console.WriteLine("armst" + "{0}{1}{2}", a, b, c);
            //        }
            //    }
            //}


            //Console.Write("m= ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int kolvo = 0;
            //while (m > 0)
            //{
            //    if ((m - n) > 0) { m = m - n; kolvo++; }
            //    if ((n - m) > 0) { n = n - m; kolvo++; }
            //    else { kolvo++; break; }

            //}
            //Console.WriteLine("kvadratov" + "{0}", kolvo);
        }
    }
}
